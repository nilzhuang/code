using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.CEnum
{
    /// <summary>
    /// 房地产统计看板枚举
    /// </summary>
    public static class EstateStatitsticsEnum
    {
        /// <summary>
        /// 图形呈载类型
        /// </summary>
        public enum HighChartType
        {
            [Description("Line")]
            line = 1,
            [Description("Pie")]
            pie = 2,
            [Description("Column")]
            column = 3
        }

        /// <summary>
        /// 物业类型
        /// </summary>
        public enum EstatePropertyType
        {
            [Description("住宅")]
            Resident = 92,
            [Description("写字楼")]
            Office = 25,
            [Description("商铺")]
            Store = 26
        }

        /// <summary>
        /// 统计类型
        /// </summary>
        public enum EstateStatitsticType
        {
            [Description("小区")]
            ResidentProject = 1,
            [Description("楼栋")]
            ResidentFloor = 2,
            [Description("单套")]
            ResidentRoom = 3,
        }

        /// <summary>
        /// 价格类型看板
        /// </summary>
        public enum PriceType
        {
            [Description("基价均值")]
            PriceAvg,
            [Description("基价中位数")]
            PriceCenter
        }

    }
}
