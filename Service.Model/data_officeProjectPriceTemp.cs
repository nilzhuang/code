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
    
    public partial class data_officeProjectPriceTemp
    {
        public long ID { get; set; }
        public Nullable<long> PlateID { get; set; }
        public Nullable<long> ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string PropertyTypeCode { get; set; }
        public string PropertyTypeName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> PriceDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string ErrorMessage { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> Submit { get; set; }
    }
}
