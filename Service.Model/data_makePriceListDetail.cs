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
    
    public partial class data_makePriceListDetail
    {
        public long ID { get; set; }
        public Nullable<long> TaskId { get; set; }
        public Nullable<long> PriceTypeId { get; set; }
        public string PriceTypeName { get; set; }
        public string PropertyTypeIds { get; set; }
        public string PropertyTypeNames { get; set; }
        public Nullable<double> SystemPrice { get; set; }
        public Nullable<double> IntervenePrice { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<long> ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Nullable<long> FloorId { get; set; }
        public string FloorName { get; set; }
        public Nullable<long> RoomId { get; set; }
        public string RoomName { get; set; }
        public Nullable<long> RegionId { get; set; }
        public string RegionName { get; set; }
        public Nullable<long> CreatePersonId { get; set; }
    }
}
