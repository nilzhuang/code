using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.CEnum
{
    #region 枚举值
    /// <summary>
    /// 业务状态
    /// </summary>
    public enum TaskState
    {
        [Description("业务创建")]
        Create = 0,
        [Description("批量作价")]
        Assessing,
        [Description("业务审核")]
        Review,
        [Description("数据入库")]
        Complete
    }
    /// <summary>
    /// 撤销状态
    /// </summary>
    public enum CancelState
    {
        /// <summary>
        /// 无状态
        /// </summary>
        [Description("无状态")]
        None = 0,
        /// <summary>
        /// 撤销完成
        /// </summary>
        [Description("撤销完成")]
        Canceled
    }
    /// <summary>
    /// 估价状态
    /// </summary>
    public enum AssessState
    {
        /// <summary>
        /// 未估价
        /// </summary>
        [Description("未估价")]
        None = 0,
        /// <summary>
        /// 计算中
        /// </summary>
        [Description("计算中")]
        Calculating,
        /// <summary>
        /// 估价完成
        /// </summary>
        [Description("估价完成")]
        Complete,
        /// <summary>
        /// 估价完成
        /// </summary>
        [Description("估价异常")]
        Error,
    }
    #endregion
}
