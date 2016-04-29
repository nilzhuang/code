using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.CEnum
{
    /// <summary>
    /// 数据导入状态
    /// </summary>
    public enum ExportTempDataStatus
    {
        Success = 0,
        Error = 1,
        /// <summary>
        /// 系统生成
        /// </summary>
        Generation = 2,
        /// <summary>
        /// 批量修改
        /// </summary>
        Updates = 3
    }
}
