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
    
    public partial class MSpeer_lsns
    {
        public int id { get; set; }
        public Nullable<System.DateTime> last_updated { get; set; }
        public string originator { get; set; }
        public string originator_db { get; set; }
        public string originator_publication { get; set; }
        public Nullable<int> originator_publication_id { get; set; }
        public Nullable<int> originator_db_version { get; set; }
        public byte[] originator_lsn { get; set; }
        public Nullable<int> originator_version { get; set; }
        public Nullable<int> originator_id { get; set; }
    }
}
