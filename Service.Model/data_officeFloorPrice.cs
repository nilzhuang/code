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
    
    public partial class data_officeFloorPrice
    {
        public long ID { get; set; }
        public long ProjectID { get; set; }
        public long FloorID { get; set; }
        public string FloorName { get; set; }
        public string FloorAddress { get; set; }
        public string PropertyType { get; set; }
        public string PropertyType4 { get; set; }
        public string RoomDistribute { get; set; }
        public string CompleteDate { get; set; }
        public string MainDirect { get; set; }
        public Nullable<decimal> ModelPrice { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> PriceDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
