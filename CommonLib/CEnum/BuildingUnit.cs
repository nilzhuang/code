using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.CEnum
{
    /// <summary>
    /// 栋单位
    /// </summary>
    public enum BuildingUnit
    {
        /// <summary>
        /// 单元
        /// </summary>
        Unit1 = 17116,
        /// <summary>
        /// 幢
        /// </summary>
        Unit3 = 17260,
        /// <summary>
        /// 号楼
        /// </summary>
        Unit4 = 17261,
        /// <summary>
        /// 座
        /// </summary>
        Unit5 = 17262,
        /// <summary>
        /// 梯
        /// </summary>
        Unit6 = 17263
    }

    /// <summary>
    /// 主朝向
    /// </summary>
    public enum Toward
    {
        /// <summary>
        /// 东
        /// </summary>
        East,
        /// <summary>
        /// 南
        /// </summary>
        South,
        /// <summary>
        /// 西
        /// </summary>
        West,
        /// <summary>
        /// 北
        /// </summary>
        North,
        /// <summary>
        /// 中
        /// </summary>
        Middle,
        /// <summary>
        /// 西北
        /// </summary>
        Northwest,
        /// <summary>
        /// 东北
        /// </summary>
        Northeast,
        /// <summary>
        /// 西南
        /// </summary>
        Southwest,
        /// <summary>
        /// 东南
        /// </summary>
        Southeast
    }

    /// <summary>
    /// 字典类别
    /// </summary>
    public enum DictType
    {
        /// <summary>
        /// 栋单位
        /// </summary>
        BuildingUnit,
        /// <summary>
        /// 主朝向
        /// </summary>
        Toward,
        /// <summary>
        /// 副朝向
        /// </summary>
        ViceOrientation
    }
}
