using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IDAL
{
    public partial interface IDbSession
    {
        #region ---有模版自动生成---
        ////每个表对应的实体仓储对象
        //IDAL.IRoleRepository RoleRepository { get; }
        //IDAL.IUserInfoRepository UserInfoRepository { get; } 
        #endregion

        //将当前应用程序跟数据库的会话内所有实体的变化更新会数据库
        int SaveChanges();

        //执行Sql语句的方法
        //EF4.0的写法
        //int ExcuteSql(string strSql, ObjectParameter[] parameters);
        //EF5.0的写法
        int ExcuteSql(string strSql, DbParameter[] parameters);

        /// <summary>
        /// 执行SQL 不需要返回类型
        /// </summary>
        /// <param name="strSql">SQL</param>
        /// <param name="parameters">参数集合</param>
        /// <returns></returns>
        int ExcuteSql(string strSql, SqlParameter[] parameters);

        /// <summary>
        /// 执行SQL 返回 DataTable
        /// 2015-5-19
        /// 马超 新增
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>DataTable</returns>
        DataTable SqlQueryForDataTable(string sql, params SqlParameter[] parameters);

        /// <summary>
        /// 批量导入 EF 实现
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="list">导入集合</param>
        /// <returns></returns>
        bool ImportData2Table<T>(IList<T> list) where T : class;
        
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="list">删除集合</param>
        /// <returns>是否成功</returns>
        bool DeleteAll<T>(List<T> list) where T : class;

        /// <summary>
        /// 将DataTable 导入 数据库
        /// </summary>
        /// <param name="tableName">目标表名</param>
        /// <param name="dt">数据集</param>
        /// <returns></returns>
        bool ExecuteSqlBulkCopy(string tableName, DataTable dt);

        /// <summary>
        /// 将DataTable 导入 数据库
        /// </summary>
        /// <param name="tableName">目标表名</param>
        /// <param name="dt">数据集</param>
        /// <param name="mapping">DataTable列与Table列映射</param>
        /// <returns></returns>
        bool ExecuteSqlBulkCopy(string tableName, DataTable dt, bool mapping);

        /// <summary>
        /// 将DataTable 异步 导入 数据库
        /// </summary>
        /// <param name="tableName">目标表名</param>
        /// <param name="dt">数据集</param>
        /// <param name="mapping">DataTable列与Table列映射</param>
        /// <returns></returns>
        bool ExecuteSqlBulkCopyAsync(string tableName, DataTable dt, bool mapping);
    }
}
