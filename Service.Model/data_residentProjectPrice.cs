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
    
    public partial class data_residentProjectPrice
    {
        public long ID { get; set; }
        public long ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public long PropertyTypeID { get; set; }
        public string PropertyTypeCode { get; set; }
        public string PropertyTypeName { get; set; }
        public Nullable<decimal> ModelPrice { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> PriceDate { get; set; }
        public string Status { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
