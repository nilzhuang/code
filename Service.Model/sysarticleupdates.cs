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
    
    public partial class sysarticleupdates
    {
        public int artid { get; set; }
        public int pubid { get; set; }
        public int sync_ins_proc { get; set; }
        public int sync_upd_proc { get; set; }
        public int sync_del_proc { get; set; }
        public bool autogen { get; set; }
        public int sync_upd_trig { get; set; }
        public Nullable<int> conflict_tableid { get; set; }
        public Nullable<int> ins_conflict_proc { get; set; }
        public bool identity_support { get; set; }
    }
}