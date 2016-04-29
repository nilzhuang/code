using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using CAAD.Common.redis;
using CAAD.DAL;
using CAAD.IBLL;
using CAAD.IDAL;
using CAAD.Model;
using log4net;
using ServiceStack.Common.Extensions;

namespace CAAD.BLL
{
    /// <summary>
    /// 字典缓存
    /// </summary>
    public class RedisCache
    {
        public readonly static RedisCache Instance = new RedisCache();
        private RedisCache()
        {
            Init();
        }

        private readonly Isys_dictRepository _dictRepository = DbSessionFactory.GetCurrenntDbSession().sys_dictRepository;
        private readonly Isys_dictTypeRepository _dictTypeRepository = DbSessionFactory.GetCurrenntDbSession().sys_dictTypeRepository;
        private readonly Isys_propertyPlateCollectsService _collectsService = new sys_propertyPlateCollectsService();
        private readonly Isys_plateInfoService _plateInfoService = new sys_plateInfoService();
        private readonly Isys_applicationService _applicationService = new sys_applicationService();
        
        private readonly ILog _log = LogManager.GetLogger("RedisCache");

        private const string TypeKeys = "DictType";
        private const string ContentKeys = "DictContent";
        private const string CollectsKeys = "RegionCollects";
        private const string PlateKeys = "PlateInfo";
        private const string ApplicationKeys = "SysApplication";
        private static readonly object ContentLocker = new object();

        /// <summary>
        /// 初始化字典
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        private void Init()
        {
            var types = _dictTypeRepository.LoadEntities(item => true).ToList();
            types.ForEach(item =>
            {
                if (RedisBase.Hash_Exist<sys_dictType>(TypeKeys, item.DictType))
                    RedisBase.Hash_Remove(TypeKeys, item.DictType);

                RedisBase.Hash_Set(TypeKeys, item.DictType, item);
            });


            var contents = _dictRepository.LoadEntities(item => true).ToList();
            contents.ForEach(item =>
            {
                if (RedisBase.Hash_Exist<sys_dict>(ContentKeys, item.DictID.ToString()))
                    RedisBase.Hash_Remove(ContentKeys, item.DictID.ToString());
                RedisBase.Hash_Set(ContentKeys, item.DictID.ToString(), item);
            });
            contents.GroupBy(item => item.DictType).ForEach(items =>
            {
                items.ForEach(item =>
                {
                    if (RedisBase.Hash_Exist<sys_dict>(items.Key, item.DictID.ToString()))
                        RedisBase.Hash_Remove(items.Key, item.DictID.ToString());
                    RedisBase.Hash_Set(items.Key, item.DictID.ToString(), item);
                });
            });
            var collects = _collectsService.LoadEntities(item => true).ToList();
            collects.ForEach(item =>
            {
                if (RedisBase.Hash_Exist<sys_propertyPlateCollects>(CollectsKeys, item.ID.ToString()))
                    RedisBase.Hash_Remove(CollectsKeys, item.ID.ToString());
                RedisBase.Hash_Set(CollectsKeys, item.ID.ToString(), item);
            });
            var plates = _plateInfoService.LoadEntities(item => true).ToList();
            plates.ForEach(item =>
            {
                if (RedisBase.Hash_Exist<sys_plateInfo>(PlateKeys, item.Pid.ToString()))
                    RedisBase.Hash_Remove(PlateKeys, item.Pid.ToString());
                RedisBase.Hash_Set(PlateKeys, item.Pid.ToString(), item);
            });

            var apps = _applicationService.LoadEntities(item => true).ToList();
            apps.ForEach(item =>
            {
                if (RedisBase.Hash_Exist<sys_application>(ApplicationKeys, item.AppKey))
                    RedisBase.Hash_Remove(ApplicationKeys, item.AppKey);
                RedisBase.Hash_Set(ApplicationKeys, item.AppKey, item);
            });


        }

        /// <summary>
        /// 刷新字典
        /// </summary>
        public void Refresh()
        {
            Clear();
            Init();
        }

        /// <summary>
        /// 清空字典
        /// </summary>
        public void Clear()
        {
            RedisBase.Hash_Remove(TypeKeys);
            RedisBase.Hash_Remove(ContentKeys);
            RedisBase.Hash_Remove(CollectsKeys);
            RedisBase.Hash_Remove(PlateKeys);
        }


        #region 字典类型

        /// <summary>
        /// 添加字典类型
        /// </summary>
        /// <param name="type"></param>
        public void AddOrUpdateDictType(sys_dictType type)
        {
            if (RedisBase.Hash_Exist<sys_dict>(TypeKeys, type.DictType))
                RedisBase.Hash_Remove(TypeKeys, type.DictType);
            RedisBase.Hash_Set(TypeKeys, type.DictType, type);
        }

        /// <summary>
        /// 删除字典类型
        /// </summary>
        /// <param name="type"></param>
        public void RemoveDictType(sys_dictType type)
        {
            if (!RedisBase.Hash_Exist<sys_dictType>(TypeKeys, type.DictType))
                return;
            RedisBase.Hash_Remove(TypeKeys, type.DictType);
        }
        /// <summary>
        /// 根据条件筛选字典类型
        /// </summary>
        /// <returns></returns>
        public List<sys_dictType> GetAllDictType()
        {
            return RedisBase.Hash_GetAll<sys_dictType>(TypeKeys);
        }

        /// <summary>
        /// 根据条件筛选字典类型
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public List<sys_dictType> DictTypeFilter(Func<sys_dictType, bool> spec)
        {
            return RedisBase.Hash_GetAll<sys_dictType>(TypeKeys).Where(spec).OrderBy(item => item.Seq).ToList();
        }


        /// <summary>
        /// 根据字典类型的主键获取字典类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public sys_dictType GetDictType(string type)
        {
            return RedisBase.Hash_Get<sys_dictType>(TypeKeys, type);
        }

        /// <summary>
        /// 根据字典类型获取起所有的子字典类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<sys_dictType> GetAllChldrenDictTypes(string type)
        {
            var allDatas = RedisBase.Hash_GetAll<sys_dictType>(TypeKeys);
            if (allDatas == null || allDatas.Count == 0)
                return new List<sys_dictType>();

            return GetChildrenDictTypes(allDatas, type);
        }

        /// <summary>
        /// 根据字典类型获取起第一级子字典类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<sys_dictType> GetChildrenDictTypes(string type)
        {
            var allDatas = RedisBase.Hash_GetAll<sys_dictType>(TypeKeys);
            if (allDatas == null || allDatas.Count == 0)
                return new List<sys_dictType>();

            return allDatas.Where(item => item.DictTypeParent == type).OrderBy(item => item.Seq).ToList();
        }

        /// <summary>
        /// 获取该字典类型的所有子字典类型
        /// </summary>
        /// <param name="allDatas">第一次取出全部数据，减少redis连接次数</param>
        /// <param name="type"></param>
        /// <returns></returns>
        private List<sys_dictType> GetChildrenDictTypes(List<sys_dictType> allDatas, string type)
        {
            var topLevels = allDatas.Where(item => item.DictTypeParent == type).ToList();
            if (topLevels.Count == 0)
                return new List<sys_dictType>();

            return topLevels.Union(topLevels.SelectMany(item => GetChildrenDictTypes(allDatas, item.DictType))).OrderBy(item => item.Seq).ToList();
        }

        /// <summary>
        /// 获取字典类型的父类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public sys_dictType GetDictTypeParent(string type)
        {

            var dictType = RedisBase.Hash_Get<sys_dictType>(TypeKeys, type);
            if (dictType == null || string.IsNullOrEmpty(dictType.DictTypeParent))
                return null;

            return RedisBase.Hash_Get<sys_dictType>(TypeKeys, dictType.DictTypeParent);
        }

        /// <summary>
        /// 获取该字典类型的级别
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int GetDictTypeLevel(string type)
        {
            var parent = GetDictTypeParent(type);
            if (parent == null || string.IsNullOrEmpty(parent.DictTypeParent))
                return 1;
            var result = GetDictTypeLevel(parent.DictTypeParent);
            return ++result;
        }


        #endregion

        #region 字典内容

        /// <summary>
        /// 添加或者更新
        /// </summary>
        /// <param name="content"></param>
        public void AddOrUpdateContent(sys_dict content)
        {
            try
            {
                if (RedisBase.Hash_Exist<sys_dict>(ContentKeys, content.DictID.ToString()))
                    RedisBase.Hash_Remove(ContentKeys, content.DictID.ToString());
                RedisBase.Hash_Set(ContentKeys, content.DictID.ToString(), content);
                if (RedisBase.Hash_Exist<sys_dict>(content.DictType, content.DictID.ToString()))
                    RedisBase.Hash_Remove(content.DictType, content.DictID.ToString());
                RedisBase.Hash_Set(content.DictType, content.DictID.ToString(), content);
            }
            catch (Exception ex)
            {
                _log.Error("AddOrUpdateContent(sys_dict content)", ex);
            }
        }

        public void AddOrUpdateContent(List<sys_dict> list)
        {
            try
            {
                foreach (var content in list)
                {
                    if (RedisBase.Hash_Exist<sys_dict>(ContentKeys, content.DictID.ToString()))
                        RedisBase.Hash_Remove(ContentKeys, content.DictID.ToString());
                    RedisBase.Hash_Set(ContentKeys, content.DictID.ToString(), content);
                    if (RedisBase.Hash_Exist<sys_dict>(content.DictType, content.DictID.ToString()))
                        RedisBase.Hash_Remove(content.DictType, content.DictID.ToString());
                    RedisBase.Hash_Set(content.DictType, content.DictID.ToString(), content);
                }
            }
            catch (Exception ex)
            {
                _log.Error("AddOrUpdateContent(List<sys_dict> list)", ex);
            }
        }

        /// <summary>
        /// 删除字典内容
        /// </summary>
        /// <param name="content"></param>
        public void RemoveContent(sys_dict content)
        {
            if (!RedisBase.Hash_Exist<sys_dict>(ContentKeys, content.DictID.ToString()))
                return;
            RedisBase.Hash_Remove(ContentKeys, content.DictID.ToString());
            if (!RedisBase.Hash_Exist<sys_dict>(content.DictType, content.DictID.ToString()))
                return;
            RedisBase.Hash_Remove(content.DictType, content.DictID.ToString());
        }

        public void RemoveContent(List<sys_dict> list)
        {
            foreach (var content in list)
            {
                if (!RedisBase.Hash_Exist<sys_dict>(ContentKeys, content.DictID.ToString()))
                    return;
                RedisBase.Hash_Remove(ContentKeys, content.DictID.ToString());
                if (!RedisBase.Hash_Exist<sys_dict>(content.DictType, content.DictID.ToString()))
                    return;
                RedisBase.Hash_Remove(content.DictType, content.DictID.ToString());
            }
        }

        /// <summary>
        /// 根据条件筛选字典内容
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public List<sys_dict> DictContentFilter(Func<sys_dict, bool> spec)
        {
            return RedisBase.Hash_GetAll<sys_dict>(ContentKeys).Where(spec).OrderBy(item => item.Seq).ToList();
        }

        /// <summary>
        /// 根据字典类型获取字典的内容
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<sys_dict> GetContentByType(string type)
        {
            return RedisBase.Hash_GetAll<sys_dict>(type) ?? new List<sys_dict>();
        }

        /// <summary>
        /// 根据字典类型获取字典的内容
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public List<sys_dict> GetContentByType(List<string> types)
        {
            var dicts = new List<sys_dict>();
            types.ForEach(item =>
            {
                var list = GetContentByType(item);
                if (list != null && list.Any())
                    dicts.AddRange(list);
            });
            return dicts;
        }

        /// <summary>
        /// 根据字典内容的主键获取内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public sys_dict GetDictContent(string id)
        {
            return RedisBase.Hash_Get<sys_dict>(ContentKeys, id) ?? new sys_dict();
        }

        /// <summary>
        /// 根据id获取内容所有的子内容
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<sys_dict> GetAllChildrenContent(string id,string type)
        {
            var allDatas = RedisBase.Hash_GetAll<sys_dict>(type);
            if (allDatas == null || allDatas.Count == 0)
                return new List<sys_dict>();

            return GetChildrenContent(allDatas, id);
        }

        /// <summary>
        /// 获取父节点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public sys_dict GetContentParent(string id)
        {
            var dict = GetDictContent(id);
            if (dict == null) return new sys_dict();
            if (dict.ParentID == "0") return dict;
            var parentDict = GetDictContent(dict.ParentID);
            return parentDict ?? dict;
        }
        
        /// <summary>
        /// 根据字典内容获取起第一级子字典内容
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<sys_dict> GetChildrenContent(string id, string type)
        {
            var allDatas = RedisBase.Hash_GetAll<sys_dict>(type);
            if (allDatas == null || allDatas.Count == 0)
                return new List<sys_dict>();

            return allDatas.Where(item => item.ParentID == id).OrderBy(item => item.Seq).ToList();
        }

        /// <summary>
        /// 获取该字典内容的所有子字典内容
        /// </summary>
        /// <param name="allDatas">第一次取出全部数据，减少redis连接次数</param>
        /// <param name="id"></param>
        /// <returns></returns>
        private List<sys_dict> GetChildrenContent(List<sys_dict> allDatas, string id)
        {
            var topLevels = allDatas.Where(item => item.ParentID == id).ToList();
            if (topLevels.Count == 0)
                return new List<sys_dict>();

            return topLevels.Union(topLevels.SelectMany(item => GetChildrenContent(allDatas, item.DictID.ToString()))).OrderBy(item => item.Seq).ToList();
        }

        /// <summary>
        /// 获取该内容的父节点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public sys_dict GetDictContentParent(string id)
        {
            var dictType = RedisBase.Hash_Get<sys_dict>(ContentKeys, id);
            if (dictType == null || string.IsNullOrEmpty(dictType.ParentID))
                return null;

            return RedisBase.Hash_Get<sys_dict>(ContentKeys, dictType.ParentID);
        }

        /// <summary>
        /// 获取该内容的级别
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetDictContentLevel(string id)
        {
            var parent = GetDictContentParent(id);
            if (parent == null || string.IsNullOrEmpty(parent.ParentID))
                return 1;
            var result = GetDictContentLevel(parent.ParentID);
            return ++result;
        }
        #endregion

        #region 区域集合

        /// <summary>
        /// 添加区域集合
        /// </summary>
        /// <param name="collects"></param>
        public void AddOrUpdateCollects(sys_propertyPlateCollects collects)
        {
            long dataKey = 0;
            dataKey = collects.ID == 0 ? RedisBase.Hash_GetDataKey(CollectsKeys) : collects.ID;
            collects.ID = dataKey;
            if (RedisBase.Hash_Exist<sys_dict>(CollectsKeys, dataKey.ToString()))
                RedisBase.Hash_Remove(CollectsKeys, dataKey.ToString());
            RedisBase.Hash_Set(CollectsKeys, dataKey.ToString(), collects);
        }

        /// <summary>
        /// 删除集合
        /// </summary>
        /// <param name="collects"></param>
        public void RemoveCollects(sys_propertyPlateCollects collects)
        {
            if (!RedisBase.Hash_Exist<sys_propertyPlateCollects>(CollectsKeys, collects.ID.ToString()))
                return;
            RedisBase.Hash_Remove(CollectsKeys, collects.ID.ToString());
        }

        /// <summary>
        /// 根据条件筛选集合
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public List<sys_propertyPlateCollects> CollectsFilter(Func<sys_propertyPlateCollects, bool> spec)
        {
            return RedisBase.Hash_GetAll<sys_propertyPlateCollects>(CollectsKeys).Where(spec).OrderBy(item => item.seq).ToList();
        }
        /// <summary>
        /// 根据集合id获得集合
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public sys_propertyPlateCollects GetCollects(string id)
        {
            return RedisBase.Hash_Get<sys_propertyPlateCollects>(CollectsKeys, id);
        }
        /// <summary>
        /// 根据市id获得区域集合
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns></returns>
        public List<sys_propertyPlateCollects> GetCollectsByCityID(long cityID)
        {
            return CollectsFilter(item => item.CityID == cityID).ToList();
        }

        #endregion

        #region 街道社区板块
        /// <summary>
        /// 添加街道社区板块
        /// </summary>
        /// <param name="plate"></param>
        public void AddOrUpdatePlateInfo(sys_plateInfo plate)
        {
            long dataKey = 0;
            dataKey = plate.Pid == 0 ? RedisBase.Hash_GetDataKey(PlateKeys) : plate.Pid;
            plate.Pid = dataKey;
            if (RedisBase.Hash_Exist<sys_plateInfo>(PlateKeys, dataKey.ToString()))
                RedisBase.Hash_Remove(PlateKeys, dataKey.ToString());
            RedisBase.Hash_Set(PlateKeys, dataKey.ToString(), plate);
        }

        /// <summary>
        /// 删除街道社区板块
        /// </summary>
        /// <param name="plate"></param>
        public void RemovePlateInfo(sys_plateInfo plate)
        {
            if (!RedisBase.Hash_Exist<sys_plateInfo>(PlateKeys, plate.Pid.ToString()))
                return;
            RedisBase.Hash_Remove(PlateKeys, plate.Pid.ToString());
        }

        /// <summary>
        /// 根据条件筛选街道社区板块
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public List<sys_plateInfo> PlateInfoFilter(Func<sys_plateInfo, bool> spec)
        {
            return RedisBase.Hash_GetAll<sys_plateInfo>(PlateKeys).Where(spec).ToList();
        }
        /// <summary>
        /// 根据集合id获得街道社区板块
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public sys_plateInfo GetPlate(string id)
        {
            return RedisBase.Hash_Get<sys_plateInfo>(PlateKeys, id);
        }
        /// <summary>
        /// 根据区县id获得街道
        /// </summary>
        /// <param name="regionID"></param>
        /// <returns></returns>
        public List<sys_plateInfo> GetStreetByRegionID(long regionID)
        {
            return PlateInfoFilter(item => item.PFid == regionID && item.Ptype == 1).ToList();
        }
        /// <summary>
        /// 根据街道id获得社区
        /// </summary>
        /// <param name="streetID"></param>
        /// <returns></returns>
        public List<sys_plateInfo> GetCommunityByStreetID(long streetID)
        {
            return PlateInfoFilter(item => item.PFid == streetID && item.Ptype == 2);
        }
        /// <summary>
        /// 根据区域集合id及物业类型id获得板块
        /// </summary>
        /// <param name="collectID">区域集合id</param>
        /// <param name="propertyID">物业类型id</param>
        /// <returns></returns>
        public List<sys_plateInfo> GetPlateByCollectAndProperty(long collectID, string propertyID)
        {
            return PlateInfoFilter(item => item.PFid == collectID && item.PDistrict == propertyID && item.Ptype == 3).ToList();
        }
        /// <summary>
        /// 根据板块id得到板块1-？
        /// </summary>
        /// <param name="plateID">板块id</param>
        /// <returns></returns>
        public List<sys_plateInfo> GetPlateChildrenByPlate(long plateID)
        {
            return PlateInfoFilter(item => item.PFid == plateID && item.Ptype == 4).ToList();
        }
        #endregion
    }
}
