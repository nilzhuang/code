//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class sys_IsQuery
    {
        public long ID { get; set; }
        public Nullable<long> OrgnazationCode { get; set; }
        public string QueryArea { get; set; }
        public string QueryProperty { get; set; }
        public string UseTemplate { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string SearchArea { get; set; }
        public string SearchProperty { get; set; }
        public string ServiceArea { get; set; }
    }
}