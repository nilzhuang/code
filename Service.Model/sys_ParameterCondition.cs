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
    
    public partial class sys_ParameterCondition
    {
        public int Id { get; set; }
        public int ParameterId { get; set; }
        public long ConditionId { get; set; }
        public Nullable<int> SelectTypeId { get; set; }
        public string SelectTypeName { get; set; }
        public bool IsUse { get; set; }
        public string VissField { get; set; }
    
        public virtual sys_Parameter sys_Parameter { get; set; }
    }
}
