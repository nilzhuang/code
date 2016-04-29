using Service.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAL
{

    public class EFContextFactory
    {
        //帮我们返回当前线程内的数据库上下文，如果当前线程内没有上下文，那么创建一个上下文，并保证
        //上线问实例在线程内部是唯一的
        internal static DbContext GetCurrentDbContext()
        {
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext;
            if (dbContext == null)  //线程在数据槽里面没有此上下文
            {
                var strage = CallContext.GetData("CurrentBranchStrage");

                dbContext = new Entities("Entities"); //创建一个EF上下文
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext;
        }
    }
}
