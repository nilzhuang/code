using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.IDAL
{
    public interface IBaseRepository<T> where T : class, new()
    {
        // 实现对数据库的添加功能,添加实现EF框架的引用
        T AddEntity(T entity);

        //实现对数据库的修改功能
        bool UpdateEntity(T entity);


        //实现对数据库的删除功能
        bool DeleteEntity(T entity);

        //实现对数据库的查询  --简单查询
        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);


        /// <summary>
        /// 实现对数据的分页查询
        /// </summary>
        /// <typeparam name="S">按照某个类进行排序</typeparam>
        /// <param name="pageIndex">当前第几页</param>
        /// <param name="pageSize">一页显示多少条数据</param>
        /// <param name="total">总条数</param>
        /// <param name="whereLambda">取得排序的条件</param>
        /// <param name="isAsc">如何排序，根据倒叙还是升序</param>
        /// <param name="orderByLambda">根据那个字段进行排序</param>
        /// <returns></returns>
        IQueryable<T> LoadPageEntities<S>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> whereLambda,
                                          bool isAsc, Expression<Func<T, S>> orderByLambda);

        /// <summary>
        /// 调用查询系数存储过程
        /// </summary>
        /// <param name="paramId">修正项ID</param>
        /// <param name="pageSize">页长</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="noPager">不用分页</param>
        /// <param name="showAll">显示全部</param>
        /// <param name="valueKey">关键字</param>
        /// <param name="status">状态</param>
        /// <param name="datePoint1">时间下限</param>
        /// <param name="datePoint2">时间上限</param>
        /// <param name="propertyCode">关联四级物业</param>
        /// <param name="conditionValueStr">基准条件</param>
        /// <param name="allCount">总条数</param>
        /// <returns></returns>
        IEnumerable<sys_ParameterValue> proc_sysParamValueSearch(int? paramId, int? pageSize, int? pageIndex, bool? noPager, bool? showAll, string valueKey, int? status, DateTime? datePoint1, DateTime? datePoint2, string propertyCode, string conditionValueStr, out int allCount);

        /// <summary>
        /// 根据条件返回总数量
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        int LoadEntitiesCount(Expression<Func<T, bool>> whereLambda);
    }
}
