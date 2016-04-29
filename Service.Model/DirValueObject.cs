using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    /// <summary>
    /// 生成目录
    /// </summary>
    public enum ProduceDirState
    {
        [Description("生成异常")]
        Error = -1,
        [Description("生成默认")]
        Default,
        [Description("生成排队中")]
        Queue,
        [Description("生成中")]
        Producing,
        [Description("生成完成")]
        Complete
    }
    /// <summary>
    /// 根据目录图片写入数据库
    /// </summary>
    public enum WriteState
    {
        [Description("写入异常")]
        Error = -1,
        [Description("写入默认")]
        Default,
        [Description("写入排队中")]
        Queue,
        [Description("写入中")]
        Writing,
        [Description("写入完成")]
        Complete
    }
}
