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
    
    public partial class data_BuildingTarget
    {
        public long ID { get; set; }
        public Nullable<long> Province { get; set; }
        public Nullable<long> City { get; set; }
        public Nullable<long> AreaID { get; set; }
        public Nullable<long> PropertyType { get; set; }
        public Nullable<decimal> CommunityNum { get; set; }
        public Nullable<System.DateTime> CommunityCompleteDate { get; set; }
        public Nullable<decimal> FloorBuildingNum { get; set; }
        public Nullable<System.DateTime> FloorBuildingCompleteDate { get; set; }
        public Nullable<decimal> RoomNum { get; set; }
        public Nullable<System.DateTime> RoomNumCompleteDate { get; set; }
        public string CreateMen { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdataMen { get; set; }
        public Nullable<System.DateTime> UpdataDate { get; set; }
        public string Remark { get; set; }
    }
}
