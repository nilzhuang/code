using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Service.IBLL;
using Service.Model;
using Service.Operate;


namespace Service.BLL
{
    public partial class sys_dictTypeService : BaseService<sys_dictType>, Isys_dictTypeService
    {

        private readonly Isys_IsQueryService _sysIsQueryService = new sys_IsQueryService();
        /// <summary>
        /// 获取当前用户所在机构的采集区域
        /// </summary>
        /// <param name="orgId">组织id</param>
        /// <param name="parentId">父节点</param>
        /// <returns></returns>
        public IEnumerable<DictAreaTreeInfo> GetIsQueryAreas(long orgId)
        {
            var areas =
                _sysIsQueryService.LoadEntities(
                    m => m.OrgnazationCode == orgId && m.QueryArea != null && m.QueryProperty == null).ToList();


            var dicts = RedisCache.Instance.DictContentFilter(d => d.DictType == "11");
                //_dictService.LoadEntities(item=>item.DictType=="11").ToList();

            var result = (from ar in areas
                join dict in dicts on ar.QueryArea equals dict.DictID.ToString() into dictInfo
                from dict in dictInfo.DefaultIfEmpty()
                select new DictAreaTreeInfo()
                {
                    id = (dict == null ? 0 : dict.DictID),
                    text = (dict == null ? "" : dict.DictText)
                }).ToList();

            return result;
        }

    }
    public class DictAreaTreeInfo
    {
        public long id { get; set; }
        public string text { get; set; }
        public string state { get; set; }
        public string _parentId { get; set; }
    }

}
