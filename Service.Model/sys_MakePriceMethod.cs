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
    
    public partial class sys_MakePriceMethod
    {
        public int ID { get; set; }
        public int PropertyID { get; set; }
        public string PropertyName { get; set; }
        public int SettingType { get; set; }
        public string SettingTypeName { get; set; }
        public int MakePriceTypeID { get; set; }
        public string MakePriceTypeName { get; set; }
        public string MethodTitle { get; set; }
        public string MethocContent { get; set; }
        public string Expression { get; set; }
        public bool IsEnable { get; set; }
        public Nullable<int> CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> EditUser { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public Nullable<int> MakePriceMethodTypeID { get; set; }
        public string MakePriceMethodTypeName { get; set; }
        public bool InitialPrice { get; set; }
        public string InitialExpression { get; set; }
        public bool UpdatePrice { get; set; }
        public string UpdateExpression { get; set; }
        public Nullable<int> TitleID { get; set; }
    }
}
