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
    
    public partial class sys_propertyTypeValue
    {
        public long Id { get; set; }
        public int AreaType { get; set; }
        public long AreaID { get; set; }
        public long PropertyTypeID { get; set; }
        public string PropertyTypeCode { get; set; }
        public string PropertyTypeName { get; set; }
        public Nullable<long> ConditionId { get; set; }
        public string ConditionCode { get; set; }
        public string ConditionValue { get; set; }
        public string ConditionValueName { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<long> Creator { get; set; }
        public string CreatorName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
