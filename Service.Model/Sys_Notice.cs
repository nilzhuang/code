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
    
    public partial class Sys_Notice
    {
        public int id { get; set; }
        public Nullable<int> Ntype { get; set; }
        public Nullable<int> NClass { get; set; }
        public string NTitle { get; set; }
        public string Nsummary { get; set; }
        public string NContent { get; set; }
        public Nullable<int> NCount { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> NScope { get; set; }
    }
}