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
    
    public partial class sys_function
    {
        public long FuncCode { get; set; }
        public string FuncName { get; set; }
        public Nullable<long> FuncGroupID { get; set; }
        public string FuncAction { get; set; }
        public string ParamInfo { get; set; }
        public string FuncDesc { get; set; }
        public Nullable<int> FuncSort { get; set; }
        public string FunAppid { get; set; }
        public string FunAppName { get; set; }
        public Nullable<long> DictID { get; set; }
        public string DictValue { get; set; }
    }
}
