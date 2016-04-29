using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.CEnum
{
    /// <summary>
    /// 四级物业类型表中AreaType类型  //区域类型（0：省份；1：市；2：区县；3：住宅小区；4：写字楼小区）
    /// </summary>
    public enum AreaType
    {
        /// <summary>
        /// 省
        /// </summary>
        Province = 0,
        /// <summary>
        /// 市
        /// </summary>
        City = 1,
        /// <summary>
        /// 区县
        /// </summary>
        County = 2,
        /// <summary>
        /// 住宅小区
        /// </summary>
        Resident = 3,
        /// <summary>
        /// 写字楼小区
        /// </summary>
        Office = 4
    }

    /// <summary>
    /// 物业类型
    /// </summary>
    public enum PropertyType
    {
        /// <summary>
        /// ParentID=134 写字楼
        /// </summary>
        OfficeBuilding = 25,

        /// <summary>
        /// ParentID=134 商铺
        /// </summary>
        Shops = 26,

        /// <summary>
        /// ParentID=134 住宅
        /// </summary>
        Residential = 92,

        /// <summary>
        /// ParentID=134 厂房
        /// </summary>
        IndustrialPlant = 96,

        /// <summary>
        /// ParentID=92 公寓
        /// </summary>
        Apartment = 93,

        /// <summary>
        /// ParentID=92 别墅
        /// </summary>
        Villa = 94,

        /// <summary>
        /// ParentID=92 辅房
        /// </summary>
        AuxiliaryRoom = 95,

        /// <summary>
        /// ParentID=0 房地产
        /// </summary>
        RealEstate = 134,

        /// <summary>
        /// ParentID=0 土地
        /// </summary>
        Lanf = 135,

        /// <summary>
        /// ParentID=25 写字楼
        /// </summary>
        Office = 10195,
        /// <summary>
        /// ParentID=25 辅房
        /// </summary>
        AuxiliaryRoom2 = 10196,
        /// <summary>
        /// ParentID=26 沿街商铺
        /// </summary>
        Shopsalongthestreet = 10246
    }

    /// <summary>
    /// 表单分组
    /// </summary>
    public enum FormGroupContact
    {
        /// <summary>
        /// 住宅小区信息表单
        /// </summary>
        ResidentProject = 172,
        /// <summary>
        /// 住宅楼栋信息表单
        /// </summary>
        ResidentFloor = 173,
        /// <summary>
        /// 住宅单套信息表单
        /// </summary>
        ResidentRoom = 174,
        /// <summary>
        /// 写字楼楼盘信息表单
        /// </summary>
        OfficeProject = 175,
        /// <summary>
        /// 写字楼楼栋信息表单
        /// </summary>
        OfficeFloor = 176,
        /// <summary>
        /// 写字楼单套信息表单
        /// </summary>
        OfficeRoom = 177
    }

    /// <summary>
    /// 特殊规则类别
    /// </summary>
    public enum SpecialRulesType
    {
        /// <summary>
        /// 房号分布特殊规则 0-0-0(1-3)
        /// </summary>
        Type1 = 1,

        /// <summary>
        /// 房号分布特殊规则 0-A-D(1-1)
        /// </summary>
        Type2 = 2,

        /// <summary>
        /// 房号分布特殊规则 0-甲-丙(1-1)
        /// </summary>
        Type3 = 3,

        /// <summary>
        /// 房号分布特殊规则 0-01-02(1-1,3-3)
        /// </summary>
        Type4 = 4,

        /// <summary>
        /// 未知
        /// </summary>
        UnKown = -1
    }

    public enum DataType
    {
        /// <summary>
        /// 导入数据
        /// </summary>
        Import = 1,
        /// <summary>
        /// 生成数据
        /// </summary>
        Generation = 2
    }
}
