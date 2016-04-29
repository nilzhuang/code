using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.CEnum
{
    public enum RegionType
    {
        ////////////////////////////////////////////////////////////////////////////
        //1省 2市 3集合 4物业类型 5板块 6板块1-1 7区县 8街道 9社区 10项目 11楼栋 12户
        //数字是在物业板块中用过  此枚举在图片分类中使用
        ///////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 省
        /// </summary>
        Province = 1,
        /// <summary>
        /// 市
        /// </summary>
        City = 2,
        /// <summary>
        /// 集合
        /// </summary>
        Collection = 3,
        /// <summary>
        /// 物业类型
        /// </summary>
        PropertyType = 4,
        /// <summary>
        /// 板块
        /// </summary>
        Plate = 5,
        /// <summary>
        /// 板块1-1
        /// </summary>
        Plate1 = 6,
        /// <summary>
        /// 区县
        /// </summary>
        County = 7,
        /// <summary>
        /// 街道
        /// </summary>
        Street = 8,
        /// <summary>
        /// 社区
        /// </summary>
        Community = 9,
        /// <summary>
        /// 住宅小区
        /// </summary>
        ResidentProject = 10,
        /// <summary>
        /// 住宅楼栋
        /// </summary>
        ResidentFloor = 11,
        /// <summary>
        /// 住宅单套
        /// </summary>
        ResidentRoom = 12,
        /// <summary>
        /// 写字楼小区
        /// </summary>
        OfficeProject = 13,
        /// <summary>
        /// 写字楼楼栋
        /// </summary>
        OfficeFloor = 14,
        /// <summary>
        /// 写字楼单套
        /// </summary>
        OfficeRoom = 15
    }
    /// <summary>
    /// 基准表单中 字段类型
    /// </summary>
    public enum FieldType
    {
        /// <summary>
        /// 日期
        /// </summary>
        Date = 164,
        /// <summary>
        /// 文本
        /// </summary>
        Text = 165,
        /// <summary>
        /// 整数
        /// </summary>
        Number = 166,
        /// <summary>
        /// 小数
        /// </summary>
        Decimal = 17460,
        /// <summary>
        /// 布尔
        /// </summary>
        Bool = 167,
        /// <summary>
        /// 下拉框
        /// </summary>
        Select = 168,
        /// <summary>
        /// 自增长
        /// </summary>
        Growth = 190,
        /// <summary>
        /// 多选
        /// </summary>
        Multiselect = 10559
    }
}
