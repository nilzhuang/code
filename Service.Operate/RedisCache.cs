using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLib.redis;
using Service.Model;

namespace Service.Operate
{
    public class RedisCache
    {
        public readonly static RedisCache Instance = new RedisCache();
        private const string TypeKeys = "DictType";
        private const string ContentKeys = "DictContent";
        private const string CollectsKeys = "RegionCollects";
        private const string PlateKeys = "PlateInfo";
        private const string ApplicationKeys = "SysApplication";
        private RedisCache()
        {

        }

        public List<sys_dict> DictContentFilter(Func<sys_dict, bool> spec)
        {
            return RedisBase.Hash_GetAll<sys_dict>(ContentKeys).Where(spec).OrderBy(item => item.Seq).ToList();
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
        /// 根据条件筛选集合
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public List<sys_propertyPlateCollects> CollectsFilter(Func<sys_propertyPlateCollects, bool> spec)
        {
            return RedisBase.Hash_GetAll<sys_propertyPlateCollects>(CollectsKeys).Where(spec).OrderBy(item => item.seq).ToList();
        }
  
    }

}
