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
    
    public partial class data_residentFloorSetting
    {
        public long ID { get; set; }
        public long FloorId { get; set; }
        public Nullable<decimal> AssessFactor { get; set; }
        public Nullable<short> IsTemplate { get; set; }
        public Nullable<int> BasicArea { get; set; }
        public Nullable<short> BasicLayer { get; set; }
        public string BasicRoomType { get; set; }
        public Nullable<short> Status { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
