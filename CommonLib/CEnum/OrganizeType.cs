using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.CEnum
{
    /// <summary>
    /// 组织机构类型
    /// </summary>
    public enum OrganizeType
    {
        /// <summary>
        /// 平台
        /// </summary>
        Platform = 0,

        /// <summary>
        /// 估价公司
        /// </summary>
        Company = 1,

        /// <summary>
        /// 分公司
        /// </summary>
        Filiale = 2,

        /// <summary>
        /// 部门
        /// </summary>
        Department = 3,

        /// <summary>
        /// 员工
        /// </summary>
        Employee = 4,

        /// <summary>
        /// 未知
        /// </summary>
        Unknown = -1
    }

    /// <summary>
    /// 客户组织机构类型
    /// </summary>
    public enum CusOrganizationType
    {
        /// <summary>
        /// 总行
        /// </summary>
        Company = 1,

        /// <summary>
        /// 支行
        /// </summary>
        Filiale = 2,

        /// <summary>
        /// 部门
        /// </summary>
        Department = 3,

        /// <summary>
        /// 未知
        /// </summary>
        Unknown = -1
    }
}
