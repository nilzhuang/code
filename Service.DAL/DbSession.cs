using Service.IBLL;
using Service.IDAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.DAL
{
    //一次跟数据库交互的会话
    public partial class DbSession : IDbSession //代表应用程序跟数据库之间的一次会话，也是数据库访问层的统一入口
    {
        private readonly DbContext _context = DAL.EFContextFactory.GetCurrentDbContext();

        public DbContext CreateDbContext()
        {
            return DAL.EFContextFactory.GetCurrentDbContext();
        }

        #region ----有模版自动生成----
        //public IDAL.IRoleRepository RoleRepository
        //{
        //    get { return new RoleRepository(); }
        //}

        //public Isys_userService sys_userRepository
        //{
        //    get { return new sys_userRepository(); }
        //} 
        //Isys_userRepository sys_userRepository { get; }
        #endregion

        //代表：当前应用程序跟数据库的会话内所有的实体的变化，更新会数据库
        public int SaveChanges()
        {
            //调用EF上下文的SaveChanges方法

            try
            {
                return _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //执行Sql脚本的方法
        public int ExcuteSql(string strSql, System.Data.Common.DbParameter[] parameters)
        {
            //Ef4.0的执行方法 ObjectContext
            //封装一个执行SQl脚本的代码
            //return DAL.EFContextFactory.GetCurrentDbContext().ExecuteFunction(strSql, parameters);
            return _context.Database.ExecuteSqlCommand(strSql, parameters);
        }

        public int ExcuteSql(string strSql, SqlParameter[] parameters)
        {
            _context.Database.CommandTimeout = 2*60;
            var task = _context.Database.ExecuteSqlCommandAsync(strSql, parameters);
            task.Wait();
            return task.IsCompleted ? 1 : 0;
        }

        /// <summary>
        /// 执行SQL 返回 DataTable
        /// 2015-5-19
        /// 马超 新增
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>DataTable</returns>
        public DataTable SqlQueryForDataTable(string sql, SqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.ConnectionString = _context.Database.Connection.ConnectionString;
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;

                    if (parameters != null && parameters.Length > 0)
                    {
                        foreach (var item in parameters)
                        {
                            cmd.Parameters.Add(item);
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    return table;
                }
                catch (Exception)
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    return table;
                }
            }
        }

        /// <summary>
        /// 批量导入 EF 实现
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool ImportData2Table<T>(IList<T> list) where T : class
        {
            _context.Configuration.AutoDetectChangesEnabled = false;
            _context.Configuration.ValidateOnSaveEnabled = false;

            DbSet<T> ds = _context.Set<T>();

            try
            {
                for (int idx = 0, len = list.Count; idx < len; idx++)
                {
                    ds.Add(list[idx]);

                    if (idx > 0 && idx % 4000 == 0)
                    {
                        _context.SaveChanges();
                    }
                    if (idx == len - 1)
                    {
                        _context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _context.Configuration.AutoDetectChangesEnabled = true;
                _context.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="list">删除集合</param>
        /// <returns>是否成功</returns>
        public bool DeleteAll<T>(List<T> list) where T : class
        {
            _context.Configuration.AutoDetectChangesEnabled = false;
            _context.Configuration.ValidateOnSaveEnabled = false;

            DbSet<T> ds = _context.Set<T>();

            try
            {
                for (int idx = 0, len = list.Count; idx < len; idx++)
                {
                    ds.Remove(list[idx]);

                    if (idx > 0 && idx % 4000 == 0)
                    {
                        _context.SaveChanges();
                    }
                    if (idx == len - 1)
                    {
                        _context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _context.Configuration.AutoDetectChangesEnabled = true;
                _context.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        /// <summary>
        /// 将DataTable 导入 数据库
        /// </summary>
        /// <param name="tableName">目标表名</param>
        /// <param name="dt">数据集</param>
        /// <returns></returns>
        public bool ExecuteSqlBulkCopy(string tableName, DataTable dt)
        {
            using (var conn = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (var bulk = new SqlBulkCopy(conn))
                {
                    try
                    {
                        bulk.DestinationTableName = tableName;
                        bulk.BatchSize = dt.Rows.Count;
                        if (dt.Rows.Count > 0)
                        {
                            conn.Open();
                            var task = bulk.WriteToServerAsync(dt);
                            task.Wait();
                            return task.IsCompleted;
                        }
                        conn.Close();
                        bulk.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        bulk.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 将DataTable 导入 数据库
        /// </summary>
        /// <param name="tableName">目标表名</param>
        /// <param name="dt">数据集</param>
        /// <param name="mapping">DataTable列与Table列映射</param>
        /// <returns></returns>
        public bool ExecuteSqlBulkCopy(string tableName, DataTable dt, bool mapping)
        {
            using (var conn = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (var bulk = new SqlBulkCopy(conn))
                {
                    try
                    {
                        bulk.DestinationTableName = tableName;
                        bulk.BatchSize = dt.Rows.Count;
                        if (mapping)
                            MappingColumns(bulk, dt.Columns);
                        if (dt.Rows.Count > 0)
                        {
                            conn.Open();
                            var task = bulk.WriteToServerAsync(dt);
                            task.Wait();
                            return task.IsCompleted;
                        }
                        conn.Close();
                        bulk.Close();
                    }
                    finally
                    {
                        conn.Close();
                        bulk.Close();
                    }
                }
            }
            return true;
        }

        public bool ExecuteSqlBulkCopyAsync(string tableName, DataTable dt, bool mapping)
        {
            using (var conn = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (var bulk = new SqlBulkCopy(conn))
                {
                    try
                    {
                        bulk.DestinationTableName = tableName;
                        bulk.BatchSize = dt.Rows.Count;
                        if (mapping)
                            MappingColumns(bulk, dt.Columns);
                        if (dt.Rows.Count > 0)
                        {
                            conn.Open();
                            var task = bulk.WriteToServerAsync(dt);
                            task.Wait();
                            return task.IsCompleted;
                        }
                    }
                    finally
                    {
                        conn.Close();
                        bulk.Close();
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 将DataTable列与Table列映射
        /// </summary>
        /// <param name="sqlBulkCopy">SqlBulkCopy</param>
        /// <param name="columns">列集合</param>
        private void MappingColumns(SqlBulkCopy sqlBulkCopy, ICollection columns)
        {
            if (columns == null || columns.Count == 0)
                return;

            foreach (DataColumn col in columns)
            {
                sqlBulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
            }
        }
    }
}
