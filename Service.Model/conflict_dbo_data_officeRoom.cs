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
    
    public partial class conflict_dbo_data_officeRoom
    {
        public Nullable<int> C___originator_id { get; set; }
        public Nullable<int> C___origin_datasource { get; set; }
        public string C___tranid { get; set; }
        public Nullable<int> C___conflict_type { get; set; }
        public Nullable<bool> C___is_winner { get; set; }
        public byte[] C___pre_version { get; set; }
        public Nullable<int> C___reason_code { get; set; }
        public string C___reason_text { get; set; }
        public byte[] C___update_bitmap { get; set; }
        public System.DateTime C___inserted_date { get; set; }
        public byte[] C___row_id { get; set; }
        public byte[] C___change_id { get; set; }
        public Nullable<long> ID { get; set; }
        public string BuildArea { get; set; }
        public string InnerArea { get; set; }
        public string ShareArea { get; set; }
        public string RealLayer { get; set; }
        public string NominalLayer { get; set; }
        public string HouseStruct { get; set; }
        public string LayerHigh { get; set; }
        public string PureHigh { get; set; }
        public string MainDirect { get; set; }
        public string MinorDirect { get; set; }
        public string RoomEvaluation { get; set; }
        public string PilarAffectEvaluation { get; set; }
        public string HasUpDownWater { get; set; }
        public string ObjectiveFactor { get; set; }
        public string Remark { get; set; }
        public string DataSrc { get; set; }
        public string DataStyle { get; set; }
        public string SurveyCompany { get; set; }
        public string Inquirer { get; set; }
        public string SurveyDate { get; set; }
        public string Verifier { get; set; }
        public string VerifyTime { get; set; }
        public string UpdatePerson { get; set; }
        public string UpdateTime { get; set; }
    }
}
