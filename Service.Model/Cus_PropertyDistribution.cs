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
    
    public partial class Cus_PropertyDistribution
    {
        public long PID { get; set; }
        public Nullable<long> Com_ID { get; set; }
        public Nullable<long> Area_ID { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public Nullable<bool> IsSelert { get; set; }
        public Nullable<double> PrintMoneyControl { get; set; }
        public Nullable<bool> IsStamp { get; set; }
        public string DictID { get; set; }
    }
}
