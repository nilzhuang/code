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
    
    public partial class data_residentRoomUpdateSolr
    {
        public long ID { get; set; }
        public long RoomId { get; set; }
        public string RoomSystemAddress { get; set; }
        public string RoomRightAddress { get; set; }
        public string ProvinceCode { get; set; }
        public string RegionCode { get; set; }
        public string CountyCode { get; set; }
        public int DataType { get; set; }
        public string CreatePerson { get; set; }
    }
}
