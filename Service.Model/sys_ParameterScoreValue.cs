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
    
    public partial class sys_ParameterScoreValue
    {
        public int Id { get; set; }
        public int ParameterScoreId { get; set; }
        public int ParameterId { get; set; }
        public int ValueId { get; set; }
        public Nullable<int> UserFloat { get; set; }
    }
}
