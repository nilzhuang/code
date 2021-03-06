﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CommonLib;
using CommonLib.CConvert;
using CommonLib.CEnum;
using log4net;
using Service.BLL;
using Service.Model;
using Service.Operate;

namespace CadService
{
    public partial class ServiceClass : ServiceBase
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(ServiceClass));
        /// <summary>
        /// 写入文件夹线程数量
        /// </summary>
        private int _produceDirThreadCount = 0;
        /// <summary>
        /// 写入db线程数量
        /// </summary>
        private int _writeDbThreadCount = 0;
        /// <summary>
        /// 写文件夹或者写数据库最大线程数
        /// </summary>
        private const int ThreadMaxCount = 4;
        /// <summary>
        /// 线程休息时间间隔
        /// </summary>
        private const int ThreaRestSpan = 1 * 6 * 1000;

        private Thread _tCreate = null; //创建文件夹线程
        private Thread _tWrite = null; //写入数据库线程
        private static List<long> WriteQuenes = new List<long>();
        private static List<long> ProduceQuenes = new List<long>();
        public ServiceClass()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _log.Info("启动服务");
            //Thread.Sleep(ThreaRestSpan);
            _tCreate = new Thread(ProduceDirScan) { IsBackground = true };
            _tCreate.Start();
            _tWrite = new Thread(WriteDbScan) { IsBackground = true };
            _tWrite.Start();
        }

        /// <summary>
        /// 服务停止 回滚状态（进行中的写入文件夹或数据库）
        /// </summary>
        protected override void OnStop()
        {
            _log.Info("停止服务");
            if (_tCreate.ThreadState == System.Threading.ThreadState.Running)
            {
                _log.Info("终止创建文件夹线程");
                _tCreate.Abort();
            }
            if (_tWrite.ThreadState == System.Threading.ThreadState.Running)
            {
                _log.Info("终止写入数据库线程");
                _tWrite.Abort();
            }
            //var ingProduceModels =
            //    _dataUploadDirectoryService.LoadEntities(o => o.ProduceDirState == (int)ProduceDirState.Producing);
            //if (ingProduceModels.Any())
            //{
            //    ingProduceModels.ToList().ForEach(item =>
            //    {
            //        item.ProduceDirState = (int)ProduceDirState.Queue;
            //        _dataUploadDirectoryService.UpdateEntity(item);
            //    });
            //}
            //var ingWriteModels =
            //  _dataUploadDirectoryService.LoadEntities(o => o.WriteState == (int)WriteState.Writing);
            //if (ingWriteModels.Any())
            //{
            //    ingWriteModels.ToList().ForEach(item =>
            //    {
            //        item.WriteState = (int)WriteState.Queue;
            //        _dataUploadDirectoryService.UpdateEntity(item);
            //    });
            //}
        }
        /// <summary>
        /// 生成文件夹处理
        /// </summary>
        void ProduceDirScan()
        {
            _log.Info("扫描生成文件夹处理");
            while (true)
            {
                try
                {
                    var dataUploadDirectoryService = new data_uploadDirectoryService();
                    var produces = dataUploadDirectoryService.LoadEntities(o => o.ProduceDirState == (int)ProduceDirState.Queue && !ProduceQuenes.Contains(o.id));

                    if (!produces.Any())
                    {
                        Thread.Sleep(ThreaRestSpan);
                        continue;
                    }
                    var produceModel = produces.OrderByDescending(o => o.id).First();
                    ProduceQuenes.Add(produceModel.id);
                    var produceId = produceModel.id;
                    if (_produceDirThreadCount < ThreadMaxCount)
                    {
                        _log.Info("即将开启新线程 _produceDirThreadCount：" + _produceDirThreadCount);

                        var thread = new Thread(() =>
                        {
                            var dataUploadDirectoryServiceChild = new data_uploadDirectoryService();
                            _log.Info("开启创建文件夹新线程");
                            var firstDirModel = dataUploadDirectoryServiceChild.LoadEntities(o => o.id == produceId).OrderByDescending(o=>o.id).First();
                            lock (this)
                            {
                                _produceDirThreadCount++;
                                if (firstDirModel == null)
                                {
                                    return;
                                }
                                firstDirModel.ProduceDirState = (int)ProduceDirState.Producing;
                                var flag = dataUploadDirectoryServiceChild.UpdateEntity(firstDirModel);
                                if (!flag)
                                {
                                    return;
                                }
                            }


                            var dirHelper = new DirHelper(firstDirModel.id, firstDirModel.CreateOrgName, firstDirModel.CreateOrgId, firstDirModel.ObjectId);
                            var produceFlag = dirHelper.DownloadDir(2, firstDirModel.ObjectId, 92);
                            if (produceFlag)
                            {
                                ProduceQuenes.Remove(produceId);
                                _produceDirThreadCount--;
                            }
                        });
                        thread.Start();
                        _log.Info("_produceDirThreadCount:" + _produceDirThreadCount);
                    }
                    Thread.Sleep(ThreaRestSpan);
                }
                catch (Exception ex)
                {
                    ProduceQuenes.Clear();
                    _produceDirThreadCount = 0;
                    _log.Error("创建扫描文件夹线程过程中出错" + ex.Message, ex);
                    Thread.Sleep(ThreaRestSpan);
                }

            }
        }
        /// <summary>
        /// 写入数据库处理
        /// </summary>
        void WriteDbScan()
        {
            _log.Info("扫描写入数据库处理");
            while (true)
            {
                try
                {
                    var dataUploadDirectoryService = new data_uploadDirectoryService();
                    var writes = dataUploadDirectoryService.LoadEntities(o => o.WriteState == (int)WriteState.Queue && !WriteQuenes.Contains(o.id));
                    if (!writes.Any())
                    {
                        Thread.Sleep(ThreaRestSpan);
                        continue;
                    }
                    var writeModel = writes.OrderByDescending(o => o.id).First();
                    WriteQuenes.Add(writeModel.id);
                    var writeId = writeModel.id;
                    if (_writeDbThreadCount < ThreadMaxCount)
                    {
                        _log.Info("即将开启新线程 _writeDbThreadCount：" + _writeDbThreadCount);
                        var thread = new Thread(() =>
                        {
                            var dataUploadDirectoryServiceChild = new data_uploadDirectoryService();
                            _log.Info("开启写入数据库新线程");
                            var firstDirModel = dataUploadDirectoryServiceChild.LoadEntities(o => o.id == writeId).OrderByDescending(o => o.id).First();
                            lock (this)
                            {
                                _writeDbThreadCount++;
                                if (firstDirModel == null)
                                {
                                    return;
                                }
                                firstDirModel.WriteState = (int)WriteState.Writing;
                                var flag = dataUploadDirectoryServiceChild.UpdateEntity(firstDirModel);
                                if (!flag)
                                {
                                    return;
                                }
                            }
                            var dirHelper = new DirHelper(firstDirModel.id, firstDirModel.CreateOrgName, firstDirModel.CreateOrgId, firstDirModel.ObjectId);
                            var produceFlag = dirHelper.UpLoadPackage();
                            if (produceFlag)
                            {
                                WriteQuenes.Remove(writeId);
                                _writeDbThreadCount--;
                            }
                        });
                        thread.Start();
                        _log.Info("_writeDbThreadCount:" + _writeDbThreadCount);
                    }
                    Thread.Sleep(ThreaRestSpan);
                }
                catch (Exception ex)
                {
                    WriteQuenes.Clear();
                    _writeDbThreadCount = 0;
                    _log.Error("创建写入数据库线程过程中出错" + ex.Message, ex);
                    Thread.Sleep(ThreaRestSpan);
                }

            }
        }

    }

    public class DirHelper
    {
        readonly data_pictureTypeService _dataPictureTypeService = new data_pictureTypeService();
        readonly data_residentProjectService _dataResidentProjectService = new data_residentProjectService();
        readonly data_residentFloorService _dataResidentFloorService = new data_residentFloorService();
        readonly data_residentRoomService _dataResidentRoomService = new data_residentRoomService();
        readonly data_officeProjectService _dataOfficeProjectService = new data_officeProjectService();
        readonly data_officeFloorService _dataOfficeFloorService = new data_officeFloorService();
        readonly data_officeRoomService _dataOfficeRoomService = new data_officeRoomService();
        data_attachmentService _attachmentService = new data_attachmentService();
        private readonly ILog _log = LogManager.GetLogger(typeof(DirHelper));
        readonly data_uploadDirectoryService _dataUploadDirectoryService = new data_uploadDirectoryService();
        private sys_dictTypeService _dictTypeService = new sys_dictTypeService();
        sys_organizeService _sysOrganizeService=new sys_organizeService();
        private long _currentDealId;//当前正在处理的生成或者写入的id
        private string _orgName;
        private long? _orgId;
        private bool upIsCounty = true; //是否是区县
        private long _objId;
        #region 文件件路径非法字符串
        public static string CleanInvalidFileName(string dirName)
        {

            dirName = dirName + "";

            dirName = InvalidFileNameChars.Aggregate(dirName, (current, c) => current.Replace(c + "", ""));
            //if (fileName.Length > 1)

            //    if (fileName[0] == '.')

            //        fileName = "dot" + fileName.TrimStart('.');



            return dirName;

        }
        private static readonly char[] InvalidFileNameChars = new[]
{

'"',

'<',

'>',

'|',

'\0',

'\u0001',

'\u0002',

'\u0003',

'\u0004',

'\u0005',

'\u0006',

'\a',

'\b',

'\t',

'\n',

'\v',

'\f',

'\r',

'\u000e',

'\u000f',

'\u0010',

'\u0011',

'\u0012',

'\u0013',

'\u0014',

'\u0015',

'\u0016',

'\u0017',

'\u0018',

'\u0019',

'\u001a',

'\u001b',

'\u001c',

'\u001d',

'\u001e',

'\u001f',

':',

'*',

'?'
};
        #endregion
        #region 图片分类生成
        public DirHelper(long currentDealId, string orgName, long? orgId, long objId)
        {
            this._currentDealId = currentDealId;
            this._orgId = orgId;
            this._objId = objId;
            var orgModel = _sysOrganizeService.LoadEntities(o => o.ID == orgId).First();
            this._orgName = orgModel.OrganizeName;
           
        }
        /// <summary>
        /// 递归创建文件夹
        /// </summary>
        /// <param name="regType"></param>
        /// <param name="lastDir"></param>
        /// <param name="id"></param>
        /// <param name="typeId"></param>
        /// <param name="byExtra"></param>
        private void RecuMakeDir(RegionType regType, StringBuilder lastDir, long id, long typeId, XmlSerializer xmlSerializer, bool byExtra = false)
        {
            try
            {
                #region 递归创建文件夹及文件
                var fileName = "";
                switch (regType)
                {
                    case RegionType.City:
                        if (AutoMakeDir(lastDir))
                        {
                            var counties = RedisCache.Instance.DictContentFilter(o => o.ParentID == id.ToString());
                            if (counties.Count > 0)
                            {
                                var xmlCounties = counties.Select(o => new XmlNode { id = o.DictID.ToString(), text = o.DictText }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCounties);  此处可用不过压缩时提示文件进程被占用
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCounties);
                                var dirCountyTemp = lastDir.ToString();
                                counties.ForEach(item =>
                                {
                                    var countyId = item.DictID;
                                    lastDir.Clear();
                                    lastDir.Append(dirCountyTemp);
                                    lastDir.Append("/" + item.DictText);
                                    const RegionType nextType = RegionType.County;
                                    RecuMakeDir(nextType, lastDir, countyId, typeId, xmlSerializer, byExtra);
                                });
                            }
                        }
                        break;
                    case RegionType.Collection:
                        break;
                    case RegionType.PropertyType:
                        break;
                    case RegionType.Plate:
                        if (AutoMakeDir(lastDir))
                        {
                            var plates1_1 = RedisCache.Instance.PlateInfoFilter(o => o.PFid == id);
                            if (plates1_1.Count > 0)
                            {
                                var xmlPlates1_1 =
                                    plates1_1.Select(
                                        o => new XmlNode { id = o.PFid.ToString(), text = o.PlateName })
                                        .ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlPlates1_1);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlPlates1_1);
                                var dirPlate1Temp = lastDir.ToString();
                                plates1_1.ForEach(itemPlate1 =>
                                {
                                    var plate1Id = itemPlate1.Pid;
                                    lastDir.Clear();
                                    lastDir.Append(dirPlate1Temp);
                                    lastDir.Append("/" + itemPlate1.PlateName);
                                    const RegionType nextType = RegionType.Plate1;
                                    RecuMakeDir(nextType, lastDir, plate1Id, typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.Plate1:
                        if (AutoMakeDir(lastDir))
                        {
                            var idStr = id.ToString();
                            var projects = _dataOfficeProjectService.LoadEntities(o => o.Plate1_1 == idStr).ToList();
                            if (projects.Count > 0)
                            {
                                var xmlProjects =
                                    projects.Select(
                                        o => new XmlNode { id = o.ID.ToString(), text = DirHelper.CleanInvalidFileName(o.ProjectName) })
                                        .ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlProjects);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlProjects);
                                var dirProjectTemp = lastDir.ToString();
                                projects.ForEach(itemProject =>
                                {
                                    var projectId = itemProject.ID;
                                    lastDir.Clear();
                                    lastDir.Append(dirProjectTemp);
                                    lastDir.Append("/" + CleanInvalidFileName(itemProject.ProjectName));
                                    const RegionType nextType = RegionType.OfficeProject;
                                    RecuMakeDir(nextType, lastDir, projectId, typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.County:
                        if (AutoMakeDir(lastDir))
                        {
                            switch (typeId)
                            {
                                case 92:
                                    if (byExtra)
                                    {
                                        var streets =
                                                        RedisCache.Instance.PlateInfoFilter(
                                                            o =>
                                                                o.PFid == id &&
                                                                o.Ptype == 1);
                                        if (streets.Count > 0)
                                        {
                                            var xmlStreets =
                                                streets.Select(o => new XmlNode { id = o.Pid.ToString(), text = o.StreetName })
                                                    .ToList();
                                            //var xmlStreetSerializer = new XmlSerializer(typeof (XmlNode));
                                            fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                            //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlStreets);
                                            SerializeXmlNodes(xmlSerializer, fileName, xmlStreets);
                                            var dirStreetTemp = lastDir.ToString();
                                            streets.ForEach(itemStreet =>
                                            {
                                                var streedId = itemStreet.Pid;
                                                lastDir.Clear();
                                                lastDir.Append(dirStreetTemp);
                                                lastDir.Append("/" + itemStreet.StreetName);
                                                const RegionType nextType = RegionType.Street;
                                                RecuMakeDir(nextType, lastDir, streedId, typeId, xmlSerializer, true);
                                            });
                                        }
                                    }
                                    else
                                    {
                                        var countyIdStr = id.ToString();
                                        var projects =
                                                              _dataResidentProjectService.LoadEntities(
                                                                  o => o.CountyCode == countyIdStr).ToList();
                                        if (projects.Count > 0)
                                        {
                                            var xmlProjects =
                                                projects.Select(
                                                    o => new XmlNode { id = o.ID.ToString(), text = CleanInvalidFileName(o.CommunityName) })
                                                    .ToList();
                                            fileName = GetXmlName(lastDir, (int)regType + "_" + countyIdStr + "_dir");
                                            //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlProjects);
                                            SerializeXmlNodes(xmlSerializer, fileName, xmlProjects);
                                            var dirProjectTemp = lastDir.ToString();
                                            projects.ForEach(itemProject =>
                                            {
                                                var projectId = itemProject.ID;
                                                lastDir.Clear();
                                                lastDir.Append(dirProjectTemp);
                                                lastDir.Append("/" + CleanInvalidFileName(itemProject.CommunityName));
                                                const RegionType nextType = RegionType.ResidentProject;
                                                RecuMakeDir(nextType, lastDir, projectId, typeId, xmlSerializer);
                                            });
                                        }
                                    }
                                    break;
                                case 25:
                                    if (byExtra)
                                    {
                                        var collect =
                                            RedisCache.Instance.CollectsFilter(
                                                o => ("|" + o.Collects + "|").Contains("|" + id.ToString() + "|")).FirstOrDefault();
                                        if (collect != null)
                                        {
                                            var plates =
                                                RedisCache.Instance.PlateInfoFilter(
                                                    o => o.PFid == collect.ID && o.Ptype == 3);
                                            if (plates.Count > 0)
                                            {
                                                var xmlPlates =
                                                plates.Select(o => new XmlNode { id = o.Pid.ToString(), text = o.PlateName })
                                                    .ToList();
                                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlPlates);
                                                SerializeXmlNodes(xmlSerializer, fileName, xmlPlates);
                                                var dirPlateTemp = lastDir.ToString();
                                                plates.ForEach(itemPlate =>
                                                {
                                                    var plateId = itemPlate.Pid;
                                                    lastDir.Clear();
                                                    lastDir.Append(dirPlateTemp);
                                                    lastDir.Append("/" + itemPlate.PlateName);
                                                    const RegionType nextType = RegionType.Plate;
                                                    RecuMakeDir(nextType, lastDir, plateId, typeId, xmlSerializer, true);
                                                });
                                            }
                                        }

                                    }
                                    else
                                    {
                                        var countyIdStr = id.ToString();
                                        var projects = _dataOfficeProjectService.LoadEntities(o => o.CountyCode == countyIdStr).ToList();
                                        if (projects.Count > 0)
                                        {
                                            var xmlProjects =
                                                projects.Select(
                                                    o => new XmlNode { id = o.ID.ToString(), text = CleanInvalidFileName(o.ProjectName) })
                                                    .ToList();
                                            fileName = GetXmlName(lastDir, (int)regType + "_" + countyIdStr + "_dir");
                                            //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlProjects);
                                            SerializeXmlNodes(xmlSerializer, fileName, xmlProjects);
                                            var dirProjectTemp = lastDir.ToString();
                                            projects.ForEach(itemProject =>
                                            {
                                                var projectId = itemProject.ID;
                                                lastDir.Clear();
                                                lastDir.Append(dirProjectTemp);
                                                lastDir.Append("/" + CleanInvalidFileName(itemProject.ProjectName));
                                                const RegionType nextType = RegionType.OfficeProject;
                                                RecuMakeDir(nextType, lastDir, projectId, typeId, xmlSerializer);
                                            });
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case RegionType.Street:
                        if (AutoMakeDir(lastDir))
                        {
                            var communities = RedisCache.Instance.PlateInfoFilter(o => o.PFid == id);
                            if (communities.Count > 0)
                            {
                                var xmlCommunities =
                                    communities.Select(
                                        o => new XmlNode { id = o.PFid.ToString(), text = CleanInvalidFileName(o.CommunityName) })
                                        .ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCommunities);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCommunities);
                                var dirCommunityTemp = lastDir.ToString();
                                communities.ForEach(itemCommunity =>
                                {
                                    var communityId = itemCommunity.Pid.ToString();
                                    lastDir.Clear();
                                    lastDir.Append(dirCommunityTemp);
                                    lastDir.Append("/" + CleanInvalidFileName(itemCommunity.CommunityName));
                                    const RegionType nextType = RegionType.Community;
                                    RecuMakeDir(nextType, lastDir, long.Parse(communityId), typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.Community:
                        if (AutoMakeDir(lastDir))
                        {
                            var idStr = id.ToString();
                            var projects =
                                _dataResidentProjectService.LoadEntities(
                                    o => o.Community == idStr).ToList();
                            if (projects.Count > 0)
                            {
                                var xmlProjects =
                                    projects.Select(
                                        o => new XmlNode { id = o.ID.ToString(), text = CleanInvalidFileName(o.CommunityName) })
                                        .ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlProjects);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlProjects);
                                var dirProjectTemp = lastDir.ToString();
                                projects.ForEach(itemProject =>
                                {
                                    var projectId = itemProject.ID;
                                    lastDir.Clear();
                                    lastDir.Append(dirProjectTemp);
                                    lastDir.Append("/" + CleanInvalidFileName(itemProject.CommunityName));
                                    const RegionType nextType = RegionType.ResidentProject;
                                    RecuMakeDir(nextType, lastDir, projectId, typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.ResidentProject:
                        var pictureTypes = _dataPictureTypeService.LoadEntities(o => true).ToList();
                        if (AutoMakeDir(lastDir))
                        {
                            var projectPicType = pictureTypes.Where(o => o.DictType == typeId.ToString() && o.RangeType == "10").ToList();
                            if (projectPicType.Count > 0)
                            {
                                var xmlCats = projectPicType.Select(o => new XmlNode { id = o.Id.ToString(), text = o.Name }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_cat");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCats);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCats);
                            }
                            projectPicType.ForEach(itemPicType => AutoMakeDir(lastDir.ToString() + "/" + itemPicType.Name));
                            var floors = _dataResidentFloorService.LoadEntities(o => o.CommunityID == id).ToList();
                            if (floors.Count > 0)
                            {
                                var xmlFloors = floors.Select(o => new XmlNode { id = o.ID.ToString(), text = CleanInvalidFileName(o.FloorName) }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlFloors);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlFloors);
                                var dirFloorTemp = lastDir.ToString();
                                floors.ForEach(floorItem =>
                                {
                                    var floorId = floorItem.ID;
                                    lastDir.Clear();
                                    lastDir.Append(dirFloorTemp);
                                    lastDir.Append("/" + CleanInvalidFileName(floorItem.FloorName));
                                    const RegionType nextType = RegionType.ResidentFloor;
                                    RecuMakeDir(nextType, lastDir, floorId, typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.ResidentFloor:
                        pictureTypes = _dataPictureTypeService.LoadEntities(o => true).ToList();
                        if (AutoMakeDir(lastDir))
                        {
                            var floorPicType = pictureTypes.Where(o => o.DictType == typeId.ToString() && o.RangeType == "11").ToList();
                            if (floorPicType.Count > 0)
                            {
                                var xmlCats = floorPicType.Select(o => new XmlNode { id = o.Id.ToString(), text = o.Name }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_cat");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCats);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCats);
                            }
                            floorPicType.ForEach(itemPicType => AutoMakeDir(lastDir.ToString() + "/" + itemPicType.Name));
                            var rooms = _dataResidentRoomService.LoadEntities(o => o.FloorID == id).ToList();
                            if (rooms.Count > 0)
                            {
                                var xmlRooms =
                                    rooms.Select(
                                        o => new XmlNode
                                        {
                                            id =
                                                o.ID.ToString(),
                                            text =
                                                CleanInvalidFileName(o.RoomSystemAddress)
                                        }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlRooms);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlRooms);
                                var dirRoomTemp = lastDir.ToString();
                                rooms.ForEach(roomItem =>
                                {
                                    var roomId = roomItem.ID;
                                    lastDir.Clear();
                                    lastDir.Append(dirRoomTemp);
                                    lastDir.Append("/" + CleanInvalidFileName(roomItem.RoomSystemAddress));
                                    const RegionType nextType = RegionType.ResidentRoom;
                                    RecuMakeDir(nextType, lastDir, roomId, typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.ResidentRoom:
                        pictureTypes = _dataPictureTypeService.LoadEntities(o => true).ToList();
                        if (AutoMakeDir(lastDir))
                        {
                            var roomPicType = pictureTypes.Where(o => o.DictType == typeId.ToString() && o.RangeType == "12").ToList();
                            if (roomPicType.Count > 0)
                            {
                                var xmlCats = roomPicType.Select(o => new XmlNode { id = o.Id.ToString(), text = o.Name }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_cat");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCats);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCats);
                            }
                            roomPicType.ForEach(itemPicType => AutoMakeDir(lastDir.ToString() + "/" + itemPicType.Name));
                        }
                        break;
                    case RegionType.OfficeProject:
                        pictureTypes = _dataPictureTypeService.LoadEntities(o => true).ToList();
                        if (AutoMakeDir(lastDir))
                        {
                            var projectPicType = pictureTypes.Where(o => o.DictType == typeId.ToString() && o.RangeType == "10").ToList();
                            if (projectPicType.Count > 0)
                            {
                                var xmlCats = projectPicType.Select(o => new XmlNode { id = o.Id.ToString(), text = o.Name }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_cat");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCats);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCats);
                            }
                            projectPicType.ForEach(itemPicType => AutoMakeDir(lastDir.ToString() + "/" + itemPicType.Name));
                            var floors = _dataOfficeFloorService.LoadEntities(o => o.ProjectId == id).ToList();
                            if (floors.Count > 0)
                            {
                                var xmlFloors = floors.Select(o => new XmlNode { id = o.ID.ToString(), text = CleanInvalidFileName(o.FloorName) }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlFloors);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlFloors);
                                var dirFloorTemp = lastDir.ToString();
                                floors.ForEach(floorItem =>
                                {
                                    var floorId = floorItem.ID;
                                    lastDir.Clear();
                                    lastDir.Append(dirFloorTemp);
                                    lastDir.Append("/" + CleanInvalidFileName(floorItem.FloorName));
                                    const RegionType nextType = RegionType.OfficeFloor;
                                    RecuMakeDir(nextType, lastDir, floorId, typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.OfficeFloor:
                        pictureTypes = _dataPictureTypeService.LoadEntities(o => true).ToList();
                        if (AutoMakeDir(lastDir))
                        {
                            var floorPicType = pictureTypes.Where(o => o.DictType == typeId.ToString() && o.RangeType == "11").ToList();
                            if (floorPicType.Count > 0)
                            {
                                var xmlCats = floorPicType.Select(o => new XmlNode { id = o.Id.ToString(), text = o.Name }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_cat");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCats);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCats);
                            }
                            floorPicType.ForEach(itemPicType => AutoMakeDir(lastDir.ToString() + "/" + itemPicType.Name));
                            var rooms = _dataOfficeRoomService.LoadEntities(o => o.BelongFloor == id).ToList();
                            if (rooms.Count > 0)
                            {
                                var xmlRooms = rooms.Select(o => new XmlNode { id = o.ID.ToString(), text = CleanInvalidFileName(o.RoomSystemAddress) }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_dir");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlRooms);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlRooms);
                                var dirRoomTemp = lastDir.ToString();
                                rooms.ForEach(roomItem =>
                                {
                                    var roomId = roomItem.ID;
                                    lastDir.Clear();
                                    lastDir.Append(dirRoomTemp);
                                    lastDir.Append("/" + CleanInvalidFileName(roomItem.RoomSystemAddress));
                                    const RegionType nextType = RegionType.ResidentRoom;
                                    RecuMakeDir(nextType, lastDir, roomId, typeId, xmlSerializer, true);
                                });
                            }
                        }
                        break;
                    case RegionType.OfficeRoom:
                        pictureTypes = _dataPictureTypeService.LoadEntities(o => true).ToList();
                        if (AutoMakeDir(lastDir))
                        {
                            var roomPicType = pictureTypes.Where(o => o.DictType == typeId.ToString() && o.RangeType == "12").ToList();
                            if (roomPicType.Count > 0)
                            {
                                var xmlCats = roomPicType.Select(o => new XmlNode { id = o.Id.ToString(), text = o.Name }).ToList();
                                fileName = GetXmlName(lastDir, (int)regType + "_" + id + "_cat");
                                //xmlSerializer.Serialize(XmlWriter.Create(fileName), xmlCats);
                                SerializeXmlNodes(xmlSerializer, fileName, xmlCats);
                            }
                            roomPicType.ForEach(itemPicType => AutoMakeDir(lastDir.ToString() + "/" + itemPicType.Name));
                        }
                        break;
                    default:
                        break;
                }
                #endregion
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                _log.Error(string.Format("异常报错信息: id:{0},typeid:{1},regType:{2},lastDir:{3},byExtra:{4}", id, typeId, regType, lastDir, byExtra), ex);
                //throw ex;
            }
        }

        /// <summary>
        /// 下载图片目录方便上传图片
        /// </summary>
        /// <param name="nodeType">节点类型</param>
        /// <param name="id">节点id</param>
        ///  /// <param name="typeId">区别物业类型</param>
        /// <param name="byExtra">需要街道及社区或者板块及板块1-1还是省去这两层目录</param>
        /// <returns></returns>
        public bool DownloadDir(long nodeType, long id, long typeId, bool byExtra = false)
        {
            var cType = RegionType.Province;
            var xmlSerializer = new XmlSerializer(typeof(List<XmlNode>));
            switch (nodeType)
            {
                case 1:
                    cType = RegionType.City;
                    break;
                case 2:
                    cType = RegionType.County;
                    break;
                case 3:
                    if (typeId == 92)
                    {
                        cType = RegionType.Street;
                    }
                    else if (typeId == 25)
                    {
                        cType = RegionType.Plate;
                    }
                    break;
                case 4:
                    if (typeId == 92)
                    {
                        cType = RegionType.Community;
                    }
                    else if (typeId == 25)
                    {
                        cType = RegionType.Plate1;
                    }
                    break;
                case 5:
                    cType = RegionType.ResidentProject;
                    break;
                case 6:
                    cType = RegionType.ResidentFloor;
                    break;
                case 7:
                    cType = RegionType.ResidentRoom;
                    break;
                case 9:
                    cType = RegionType.OfficeProject;
                    break;
                case 10:
                    cType = RegionType.OfficeFloor;
                    break;
                case 11:
                    cType = RegionType.OfficeRoom;
                    break;
            }

            var dirName = new StringBuilder();
            string baseDir = ConfigurationManager.AppSettings["baseProduceDir"];
            dirName.Append(baseDir);
            if (string.IsNullOrEmpty(this._orgName))
            {
                _log.Error(string.Format("创建文件夹信息：nodeType:{0},id:{1},typeId:{2},byExtra:{3},_orgName:{4}异常跳出", cType, id, typeId, byExtra, this._orgName));
                UpdateException(this._currentDealId);
                return false;
            }
            dirName.Append("/" + this._orgName);

            var dictModel = RedisCache.Instance.DictContentFilter(o => o.DictID == this._objId).FirstOrDefault();
            if (dictModel == null)
            {
                _log.Error("创建文件夹时找不到对应省市区:" + this._objId);
                UpdateException(this._currentDealId);
                return false;
            }
            dirName.Append("/" + dictModel.DictText);
            _log.Info(string.Format("创建文件夹信息：nodeType:{0},id:{1},typeId:{2},byExtra:{3}开始", cType, id, typeId, byExtra));
            try
            {
                RecuMakeDir(cType, dirName, id, typeId, xmlSerializer, byExtra);
            }
            catch
            {
                //Todo 写入数据库提示此条任务写入文件夹失败
                UpdateException(this._currentDealId);
                return false;
            }

            _log.Info(string.Format("创建文件夹信息：nodeType:{0},id:{1},typeId:{2},byExtra:{3}结束", cType, id, typeId, byExtra));
            UpdateComplete(_currentDealId, this._orgName);
            return true;
        }

        /// <summary>
        /// 修改异常信息true写入文件夹异常，false写入数据库异常
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="flag">true写入文件夹异常，false写入数据库异常</param>
        void UpdateException(long taskId, bool flag = true)
        {
            var model = _dataUploadDirectoryService.LoadEntities(o => o.id == taskId).OrderByDescending(o => o.id).FirstOrDefault();
            if (model != null)
            {
                if (flag)
                {
                    model.ProduceDirState = (int)ProduceDirState.Error;
                }
                else
                {
                    model.WriteState = (int)WriteState.Error;
                }
                _dataUploadDirectoryService.UpdateEntity(model);
            }
        }
        /// <summary>
        /// 修改完成信息true写入文件夹完成，false写入数据库完成
        /// </summary>
        /// <param name="baseDirName">需要开的ftp名称</param>
        /// <param name="taskId"></param>
        /// <param name="flag">true写入文件夹完成，false写入数据库完成</param>
        void UpdateComplete(long taskId, string baseDirName, bool flag = true)
        {
            var model = _dataUploadDirectoryService.LoadEntities(o => o.id == taskId).OrderByDescending(o => o.id).FirstOrDefault();
            if (model != null)
            {
                if (flag)
                {
                    model.ProduceDirState = (int)ProduceDirState.Complete;
                }
                else
                {
                    model.WriteState = (int)WriteState.Complete;
                }
                model.BaseDirPath = baseDirName;
                _dataUploadDirectoryService.UpdateEntity(model);
            }
        }
        /// <summary>
        /// 自动创建文件夹
        /// </summary>
        /// <param name="dirName"></param>
        /// <returns></returns>
        bool AutoMakeDir(object dirName)
        {
            string strDirName = dirName.ToString();
            try
            {
                if (!Directory.Exists(strDirName))
                {
                    Directory.CreateDirectory(strDirName);
                }
                return true;
            }
            catch (Exception ex)
            {
                _log.Error("创建文件夹失败" + strDirName, ex);
                throw new Exception(ex.Message + ";" + dirName);
            }
        }

        /// <summary>
        /// 取的xml文件名称
        /// </summary>
        /// <param name="dirName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetXmlName(StringBuilder dirName, object id)
        {
            return string.Format("{0}/{1}.xml", dirName, id);
        }

        /// <summary>
        /// 文件流自动释放进程 
        /// </summary>
        /// <param name="serialize"></param>
        /// <param name="filePath"></param>
        /// <param name="nodes"></param>
        void SerializeXmlNodes(XmlSerializer serialize, string filePath, List<XmlNode> nodes)
        {
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                serialize.Serialize(fs, nodes);
            }
        }

        #endregion

        #region 图片文件存数据库

        public bool UpLoadPackage()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<XmlNode>));
            if (!this._orgId.HasValue)
            {
                _log.Error(string.Format("orgId:{0} orgId为空", this._orgId));
                UpdateException(this._currentDealId, false);
                return false;
            }
            try
            {
                var ls =
               (from d in
                    _dictTypeService.GetIsQueryAreas(this._orgId.Value)
                select new { d.id }).ToList().Select(o => o.id).ToList();
                var searchDirName = ConfigurationManager.AppSettings["baseProduceDir"] + "/" + this._orgName;
                var dictModel = RedisCache.Instance.DictContentFilter(o => o.DictID == this._objId).FirstOrDefault();
                if (dictModel == null)
                {
                    _log.Error("写入数据库时找不到对应省市区文件夹:" + this._objId);
                    UpdateException(this._currentDealId, false);
                    return false;
                }
                searchDirName = searchDirName + "/" + dictModel.DictText;
                _log.Info(string.Format("写入数据开始：searchDirName:{0}开始", searchDirName));
                RecuUpFile(new StringBuilder(searchDirName), xmlSerializer, ls);
                UpdateComplete(_currentDealId, this._orgName, false);
                _log.Info(string.Format("写入数据开始：searchDirName:{0}结束", searchDirName));
                return true;
            }
            catch (Exception ex)
            {
                _log.Error(string.Format("orgId:{0} {1}", this._orgId, ex.Message), ex);
                UpdateException(this._currentDealId, false);
                return false;
            }
        }
        /// <summary>
        /// 递归上传文件
        /// </summary>
        /// <param name="lastDir"></param>
        /// <param name="xmlSerializer"></param>
        void RecuUpFile(StringBuilder lastDir, XmlSerializer xmlSerializer, List<long> ls)
        {
            try
            {
                var errInfo = "";
                string[] files = null;
                try
                {
                    if (!Directory.Exists(lastDir.ToString()))
                    {
                        errInfo = string.Format("{0}路径不存在", lastDir);
                        _log.Error(errInfo);
                        return;
                    }
                    files = Directory.GetFiles(lastDir.ToString());
                }
                catch (Exception ex)
                {
                    _log.Error(lastDir.ToString() + "异常", ex);
                    return;
                    //如果xml文件中有文件件名称 文件夹被删除 此处不做操作
                }
                if (files.Length != 0)
                {
                    var catXml = files.FirstOrDefault(o => o.Contains("cat.xml"));
                    if (!string.IsNullOrEmpty(catXml))
                    {
                        using (var fs = new StreamReader(catXml))
                        {
                            var nodes = xmlSerializer.Deserialize(fs) as List<XmlNode>;
                            var fileName = Path.GetFileName(catXml);
                            if (string.IsNullOrEmpty(fileName))
                            {
                                return;
                            }
                            var arr = fileName.Split('_');
                            if (nodes == null) return;
                            var objId = ZConvert.To<long>(arr[1]);
                            switch ((RegionType)ZConvert.To<int>(arr[0]))
                            {
                                case RegionType.Province:
                                case RegionType.City:
                                case RegionType.County:
                                    if (ls.Contains(ZConvert.To<long>(arr[1])))
                                    {
                                        return;
                                    }
                                    break;
                                case RegionType.ResidentProject:
                                case RegionType.ResidentFloor:
                                case RegionType.ResidentRoom:
                                    var sbTemp = new StringBuilder(lastDir.ToString());
                                    nodes.ForEach(item =>
                                    {
                                        sbTemp.Append("/" + item.text);
                                        RecordAndUpFiles(sbTemp.ToString(), objId, ZConvert.To<int>(item.id),
                                            (RegionType)ZConvert.To<int>(arr[0]));
                                        sbTemp = new StringBuilder(lastDir.ToString());
                                    });
                                    break;
                                case RegionType.OfficeProject:
                                    var sbTemp1 = new StringBuilder(lastDir.ToString());
                                    nodes.ForEach(item =>
                                    {
                                        sbTemp1.Append("/" + item.text);
                                        RecordAndUpFiles(sbTemp1.ToString(), objId, ZConvert.To<int>(item.id),
                                            RegionType.ResidentProject);
                                        sbTemp1 = new StringBuilder(lastDir.ToString());
                                    });
                                    break;
                                case RegionType.OfficeFloor:
                                    var sbTemp2 = new StringBuilder(lastDir.ToString());
                                    nodes.ForEach(item =>
                                    {
                                        sbTemp2.Append("/" + item.text);
                                        RecordAndUpFiles(sbTemp2.ToString(), objId, ZConvert.To<int>(item.id),
                                            RegionType.ResidentFloor);
                                        sbTemp2 = new StringBuilder(lastDir.ToString());
                                    });
                                    break;
                                case RegionType.OfficeRoom:
                                    var sbTemp3 = new StringBuilder(lastDir.ToString());
                                    nodes.ForEach(item =>
                                    {
                                        sbTemp3.Append("/" + item.text);
                                        RecordAndUpFiles(sbTemp3.ToString(), objId, ZConvert.To<int>(item.id),
                                            RegionType.ResidentRoom);
                                        sbTemp3 = new StringBuilder(lastDir.ToString());
                                    });
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }

                        }
                    }
                    var dirXml = files.FirstOrDefault(o => o.Contains("dir.xml"));
                    if (!string.IsNullOrEmpty(dirXml))
                    {
                        string upImgErrorInfo = "";
                        if (upIsCounty)
                        {
                            upIsCounty = false;
                            var fname = Path.GetFileName(dirXml);
                            var names = fname.Split('_');
                            if (names[0] != ((int)RegionType.County).ToString())
                            {
                                upImgErrorInfo = "请上传当前区县下图片！";
                            }
                            else if (names[1] != this._objId.ToString())
                            {
                                upImgErrorInfo = "请上传当前区县下图片！";
                            }
                            if (!string.IsNullOrEmpty(upImgErrorInfo))
                            {
                                _log.Error("区县不对" + names[1]);
                                return;  //如果上传的不是当前右键节点的区县则返回
                            }
                        }
                        using (var fs = new StreamReader(dirXml))
                        {
                            var nodes = xmlSerializer.Deserialize(fs) as List<XmlNode>;
                            if (nodes == null) return;
                            var sbTemp = new StringBuilder(lastDir.ToString());
                            nodes.ForEach(item =>
                            {
                                sbTemp.Append("/" + item.text);
                                RecuUpFile(sbTemp, xmlSerializer, ls);
                                sbTemp = new StringBuilder(lastDir.ToString());
                            });
                        }

                    }
                }
                else
                {
                    var dirs = Directory.GetDirectories(lastDir.ToString());
                    dirs.ToList().ForEach(d =>
                    {
                        lastDir = new StringBuilder(d);
                        RecuUpFile(lastDir, xmlSerializer, ls);
                    });

                }
            }
            catch (System.Data.SqlClient.SqlException eex)
            {
                _log.Error("写入过程中发生问题" + eex.Message, eex);
            }

        }

        /// <summary>
        /// 写入数据库及上传
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="objId"></param>
        /// <param name="picTypeId"></param>
        /// <param name="regionType"></param>
        private void RecordAndUpFiles(string dir, long objId, int picTypeId, RegionType regionType)
        {

            try
            {
                var pat = @"(.jpg)|(.png)|(.jpeg)|(.gif)";
                var files = Directory.GetFiles(dir);
                files.ToList().ForEach(item =>
                {
                    var ext = Path.GetExtension(item);
                    if (ext != null)
                    {
                        var extL = ext.ToLower();
                        if (Regex.IsMatch(extL, pat) && item.IndexOf("_thumbnail") == -1)
                        {
                            var fullPath = SaveData(item, picTypeId, ((int)regionType).ToString(), objId);
                            var dirPath = Path.GetDirectoryName(fullPath);
                            var thumbnailPath = Path.Combine(dirPath, GeneralThumbnailFileName(fullPath));
                            if (!File.Exists(thumbnailPath))
                                MakeThumbnail(fullPath, thumbnailPath, 80, 60, "HW");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                //Session["UpImgErrorInfo"] = ex.Message;
                //SetErrorCookie(ex.Message);
                _log.Error(ex.ToString(), ex);
            }

        }

        public string FtpRoot { get { return ConfigurationManager.AppSettings["picRoot"]; } }
        /// <summary>
        /// 写入数据库
        /// </summary>
        /// <param name="rFilePath"></param>
        /// <param name="pictureTypeId"></param>
        /// <param name="moduleName"></param>
        /// <param name="objId"></param>
        /// <param name="fileType"></param>
        /// <returns></returns>
        private string SaveData(string rFilePath, int pictureTypeId, string moduleName, long objId, string fileType = "picture")
        {
            //var typeId = 0;
            //if (!int.TryParse(pictureUrl.PictureType, out typeId))
            //{
            //    typeId = -1;
            //}
            //var dictType = "Other";
            //var tmp = _pictureTypeService.LoadEntities(item => item.Id == pictureTypeId).FirstOrDefault();
            //if (tmp != null)
            //{
            //long dictID = ZConvert.To<long>(tmp.DictType);
            //物业类型
            //var firstOrDefault = RedisCache.Instance.DictContentFilter(o => o.DictID == dictID).FirstOrDefault();
            //if (firstOrDefault != null)
            //    dictType = firstOrDefault.DictValue;
            //(RedisCache.Instance.GetDictType(tmp.DictType) ?? new sys_dictType()).DictTypeName;
            //}
            var fullName = rFilePath;

            var picPath = fullName.Replace(FtpRoot, "").Replace("\\", "/");

            //重复图片上传处理
            var filename = Path.GetFileName(rFilePath);
            var attachs =
                _attachmentService.LoadEntities(
                    o => o.FileName == filename && o.ModuleKey == objId.ToString() && o.ModuleName == moduleName && o.PictureType == pictureTypeId && o.FileSize == 0)
                    .ToList();
            if (attachs.Count == 0) //当前分类下 没有这个名称的图片才上传
            {
                var entity = new data_attachment
                {
                    CreateDate = DateTime.Now,
                    FileName = Path.GetFileName(rFilePath),
                    FileSize = 0,
                    FileType = fileType,
                    FileUrl = picPath,
                    ModuleKey = objId.ToString(),
                    ModuleName = moduleName,
                    PictureType = pictureTypeId,
                    MD5 = ""
                };
                //entity.CreatePerson = AuthInfoStore.Instance.CurrentUser.Name;
                _attachmentService.AddEntity(entity);
            }
            return fullName;
        }
        /// <summary>
        /// 生成缩略图的路径
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GeneralThumbnailFileName(string fileName)
        {
            return string.Format("{0}_thumbnail{1}", Path.GetFileNameWithoutExtension(fileName),
               Path.GetExtension(fileName));
        }
        #region 生成缩略图并上传
        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="originalImagePath"></param>
        /// <param name="thumbnailPath"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="mode"></param>
        private void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode)
        {
            Image originalImage = Image.FromFile(originalImagePath);

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）                 
                    break;
                case "W"://指定宽，高按比例                     
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例 
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）                 
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片 
            Image bitmap = new System.Drawing.Bitmap(towidth, toheight);

            //新建一个画板 
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);

            //设置高质量插值法 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            //设置高质量,低速度呈现平滑程度 
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //清空画布并以透明背景色填充 
            g.Clear(Color.Transparent);

            //在指定位置并且按指定大小绘制原图片的指定部分 
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                new Rectangle(x, y, ow, oh),
                GraphicsUnit.Pixel);

            try
            {
                var dirs = Path.GetDirectoryName(thumbnailPath);
                if (dirs != null && !Directory.Exists(dirs))
                {
                    Directory.CreateDirectory(dirs);
                }
                //以jpg格式保存缩略图 
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }

        }
        #endregion
        #endregion
    }
    #region xml辅助类

    [Serializable]
    public class XmlNode
    {
        public string id { get; set; }
        public string text { get; set; }
    }
    #endregion
}
