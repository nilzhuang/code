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
    
    public partial class MSpeer_conflictdetectionconfigrequest
    {
        public int id { get; set; }
        public string publication { get; set; }
        public System.DateTime sent_date { get; set; }
        public int timeout { get; set; }
        public System.DateTime modified_date { get; set; }
        public string progress_phase { get; set; }
        public bool phase_timed_out { get; set; }
    }
}