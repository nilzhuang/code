﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Core.Objects;

namespace Service.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
              
        }
    
    	
        public Entities(string nameOrConnectionString)
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cus_AppraisalInstitution> Cus_AppraisalInstitution { get; set; }
        public virtual DbSet<Cus_AreaDistribution> Cus_AreaDistribution { get; set; }
        public virtual DbSet<Cus_Branch> Cus_Branch { get; set; }
        public virtual DbSet<Cus_Company> Cus_Company { get; set; }
        public virtual DbSet<Cus_Config> Cus_Config { get; set; }
        public virtual DbSet<Cus_IsQuery> Cus_IsQuery { get; set; }
        public virtual DbSet<Cus_Organization> Cus_Organization { get; set; }
        public virtual DbSet<Cus_Post> Cus_Post { get; set; }
        public virtual DbSet<Cus_PriceResultConfig> Cus_PriceResultConfig { get; set; }
        public virtual DbSet<Cus_PropertyDistribution> Cus_PropertyDistribution { get; set; }
        public virtual DbSet<Cus_Role> Cus_Role { get; set; }
        public virtual DbSet<Cus_RoleMenu> Cus_RoleMenu { get; set; }
        public virtual DbSet<Cus_RoleUser> Cus_RoleUser { get; set; }
        public virtual DbSet<Cus_ServiceArea> Cus_ServiceArea { get; set; }
        public virtual DbSet<Cus_TempletDistribution> Cus_TempletDistribution { get; set; }
        public virtual DbSet<Cus_User> Cus_User { get; set; }
        public virtual DbSet<data_attachment> data_attachment { get; set; }
        public virtual DbSet<data_baseInfoAllFields> data_baseInfoAllFields { get; set; }
        public virtual DbSet<data_baseInfoGroup> data_baseInfoGroup { get; set; }
        public virtual DbSet<data_baseInfoGroupFields> data_baseInfoGroupFields { get; set; }
        public virtual DbSet<data_BuildingTarget> data_BuildingTarget { get; set; }
        public virtual DbSet<data_HousingCase> data_HousingCase { get; set; }
        public virtual DbSet<data_HousingLeaseCase> data_HousingLeaseCase { get; set; }
        public virtual DbSet<data_makePriceList> data_makePriceList { get; set; }
        public virtual DbSet<data_makePriceListDetail> data_makePriceListDetail { get; set; }
        public virtual DbSet<data_makePriceListMethod> data_makePriceListMethod { get; set; }
        public virtual DbSet<data_makePriceListObject> data_makePriceListObject { get; set; }
        public virtual DbSet<data_makePriceListObjectTemp> data_makePriceListObjectTemp { get; set; }
        public virtual DbSet<data_makePriceListProcess> data_makePriceListProcess { get; set; }
        public virtual DbSet<data_makePriceListResult> data_makePriceListResult { get; set; }
        public virtual DbSet<data_MakePriceSubmitLog> data_MakePriceSubmitLog { get; set; }
        public virtual DbSet<data_NewsBulletinInfo> data_NewsBulletinInfo { get; set; }
        public virtual DbSet<data_OfficeBuildingsCase> data_OfficeBuildingsCase { get; set; }
        public virtual DbSet<data_OfficeBuildingsLeaseCase> data_OfficeBuildingsLeaseCase { get; set; }
        public virtual DbSet<data_officeFloor> data_officeFloor { get; set; }
        public virtual DbSet<data_officeFloorPrice> data_officeFloorPrice { get; set; }
        public virtual DbSet<data_officeFloorPriceTemp> data_officeFloorPriceTemp { get; set; }
        public virtual DbSet<data_officeFloorTemp> data_officeFloorTemp { get; set; }
        public virtual DbSet<data_officeFloorUpdateSolr> data_officeFloorUpdateSolr { get; set; }
        public virtual DbSet<data_officeProject> data_officeProject { get; set; }
        public virtual DbSet<data_officeProjectPrice> data_officeProjectPrice { get; set; }
        public virtual DbSet<data_officeProjectPriceTemp> data_officeProjectPriceTemp { get; set; }
        public virtual DbSet<data_officeProjectPropertyType> data_officeProjectPropertyType { get; set; }
        public virtual DbSet<data_officeProjectSummaryPrice> data_officeProjectSummaryPrice { get; set; }
        public virtual DbSet<data_officeProjectTemp> data_officeProjectTemp { get; set; }
        public virtual DbSet<data_officeProjectUpdateSolr> data_officeProjectUpdateSolr { get; set; }
        public virtual DbSet<data_officeRoom> data_officeRoom { get; set; }
        public virtual DbSet<data_officeRoomPrice> data_officeRoomPrice { get; set; }
        public virtual DbSet<data_officeRoomPriceTemp> data_officeRoomPriceTemp { get; set; }
        public virtual DbSet<data_officeRoomTemp> data_officeRoomTemp { get; set; }
        public virtual DbSet<data_officeRoomUpdateSolr> data_officeRoomUpdateSolr { get; set; }
        public virtual DbSet<data_opinionLibrary> data_opinionLibrary { get; set; }
        public virtual DbSet<data_pictureType> data_pictureType { get; set; }
        public virtual DbSet<data_residentFloor> data_residentFloor { get; set; }
        public virtual DbSet<data_residentFloorPrice> data_residentFloorPrice { get; set; }
        public virtual DbSet<data_residentFloorPriceTemp> data_residentFloorPriceTemp { get; set; }
        public virtual DbSet<data_residentFloorSetting> data_residentFloorSetting { get; set; }
        public virtual DbSet<data_residentFloorTemp> data_residentFloorTemp { get; set; }
        public virtual DbSet<data_residentFloorUpdateSolr> data_residentFloorUpdateSolr { get; set; }
        public virtual DbSet<data_residentProject> data_residentProject { get; set; }
        public virtual DbSet<data_residentProjectCashability> data_residentProjectCashability { get; set; }
        public virtual DbSet<data_residentProjectPrice> data_residentProjectPrice { get; set; }
        public virtual DbSet<data_residentProjectPriceTemp> data_residentProjectPriceTemp { get; set; }
        public virtual DbSet<data_residentProjectPropertyType> data_residentProjectPropertyType { get; set; }
        public virtual DbSet<data_residentProjectSummaryPrice> data_residentProjectSummaryPrice { get; set; }
        public virtual DbSet<data_residentProjectTemp> data_residentProjectTemp { get; set; }
        public virtual DbSet<data_residentProjectUpdateSolr> data_residentProjectUpdateSolr { get; set; }
        public virtual DbSet<data_residentRoom> data_residentRoom { get; set; }
        public virtual DbSet<data_residentRoomPrice> data_residentRoomPrice { get; set; }
        public virtual DbSet<data_residentRoomPriceTemp> data_residentRoomPriceTemp { get; set; }
        public virtual DbSet<data_residentRoomSetting> data_residentRoomSetting { get; set; }
        public virtual DbSet<data_residentRoomTemp> data_residentRoomTemp { get; set; }
        public virtual DbSet<data_residentRoomUpdateSolr> data_residentRoomUpdateSolr { get; set; }
        public virtual DbSet<data_residentTradeCase> data_residentTradeCase { get; set; }
        public virtual DbSet<data_uploadDirectory> data_uploadDirectory { get; set; }
        public virtual DbSet<EstateStatitstics> EstateStatitstics { get; set; }
        public virtual DbSet<FloorFittedData> FloorFittedData { get; set; }
        public virtual DbSet<FloorPriceChangeRatioData> FloorPriceChangeRatioData { get; set; }
        public virtual DbSet<FloorSmoothData> FloorSmoothData { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigrequest> MSpeer_conflictdetectionconfigrequest { get; set; }
        public virtual DbSet<MSpeer_lsns> MSpeer_lsns { get; set; }
        public virtual DbSet<ProjectFittedData> ProjectFittedData { get; set; }
        public virtual DbSet<ProjectPriceChangeRatioData> ProjectPriceChangeRatioData { get; set; }
        public virtual DbSet<ProjectSmoothData> ProjectSmoothData { get; set; }
        public virtual DbSet<RoomFittedData> RoomFittedData { get; set; }
        public virtual DbSet<RoomPriceChangeRatioData> RoomPriceChangeRatioData { get; set; }
        public virtual DbSet<RoomSmoothData> RoomSmoothData { get; set; }
        public virtual DbSet<sys_application> sys_application { get; set; }
        public virtual DbSet<sys_CAADMethod> sys_CAADMethod { get; set; }
        public virtual DbSet<sys_CAADMethodProperty> sys_CAADMethodProperty { get; set; }
        public virtual DbSet<sys_CusOrgRelation> sys_CusOrgRelation { get; set; }
        public virtual DbSet<sys_dict> sys_dict { get; set; }
        public virtual DbSet<sys_dictOrganize> sys_dictOrganize { get; set; }
        public virtual DbSet<sys_dictType> sys_dictType { get; set; }
        public virtual DbSet<sys_employee> sys_employee { get; set; }
        public virtual DbSet<sys_fucGroup> sys_fucGroup { get; set; }
        public virtual DbSet<sys_function> sys_function { get; set; }
        public virtual DbSet<sys_generateRule> sys_generateRule { get; set; }
        public virtual DbSet<sys_gis> sys_gis { get; set; }
        public virtual DbSet<Sys_Glossary> Sys_Glossary { get; set; }
        public virtual DbSet<sys_HelpContent> sys_HelpContent { get; set; }
        public virtual DbSet<sys_HelpGroup> sys_HelpGroup { get; set; }
        public virtual DbSet<sys_IsQuery> sys_IsQuery { get; set; }
        public virtual DbSet<sys_jobs> sys_jobs { get; set; }
        public virtual DbSet<sys_MakePriceMethod> sys_MakePriceMethod { get; set; }
        public virtual DbSet<sys_MakePriceQuery> sys_MakePriceQuery { get; set; }
        public virtual DbSet<sys_MakePriceTemplate> sys_MakePriceTemplate { get; set; }
        public virtual DbSet<sys_menu> sys_menu { get; set; }
        public virtual DbSet<sys_MethodTitle> sys_MethodTitle { get; set; }
        public virtual DbSet<sys_organize> sys_organize { get; set; }
        public virtual DbSet<sys_organize_bak> sys_organize_bak { get; set; }
        public virtual DbSet<sys_OrganizeMakePriceMethod> sys_OrganizeMakePriceMethod { get; set; }
        public virtual DbSet<sys_Parameter> sys_Parameter { get; set; }
        public virtual DbSet<sys_ParameterCondition> sys_ParameterCondition { get; set; }
        public virtual DbSet<sys_ParameterConditionValue> sys_ParameterConditionValue { get; set; }
        public virtual DbSet<sys_ParameterScore> sys_ParameterScore { get; set; }
        public virtual DbSet<sys_ParameterScoreValue> sys_ParameterScoreValue { get; set; }
        public virtual DbSet<sys_ParameterSetting> sys_ParameterSetting { get; set; }
        public virtual DbSet<sys_ParameterValue> sys_ParameterValue { get; set; }
        public virtual DbSet<sys_plateInfo> sys_plateInfo { get; set; }
        public virtual DbSet<sys_PriceProportion> sys_PriceProportion { get; set; }
        public virtual DbSet<sys_Product> sys_Product { get; set; }
        public virtual DbSet<sys_ProductAuthorization> sys_ProductAuthorization { get; set; }
        public virtual DbSet<sys_propertyPlateCollects> sys_propertyPlateCollects { get; set; }
        public virtual DbSet<sys_propertyTypeCondition> sys_propertyTypeCondition { get; set; }
        public virtual DbSet<sys_propertyTypeValue> sys_propertyTypeValue { get; set; }
        public virtual DbSet<sys_propertyTypeValueOrganization> sys_propertyTypeValueOrganization { get; set; }
        public virtual DbSet<sys_role> sys_role { get; set; }
        public virtual DbSet<sys_roleMenu> sys_roleMenu { get; set; }
        public virtual DbSet<sys_roleUser> sys_roleUser { get; set; }
        public virtual DbSet<sys_Tax> sys_Tax { get; set; }
        public virtual DbSet<sys_UsageLog> sys_UsageLog { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }
        public virtual DbSet<sys_userTemplate> sys_userTemplate { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<sysreplservers> sysreplservers { get; set; }
        public virtual DbSet<conflict_dbo_data_officeFloor> conflict_dbo_data_officeFloor { get; set; }
        public virtual DbSet<conflict_dbo_data_officeProject> conflict_dbo_data_officeProject { get; set; }
        public virtual DbSet<conflict_dbo_data_officeRoom> conflict_dbo_data_officeRoom { get; set; }
        public virtual DbSet<conflict_dbo_data_residentFloor> conflict_dbo_data_residentFloor { get; set; }
        public virtual DbSet<conflict_dbo_data_residentProject> conflict_dbo_data_residentProject { get; set; }
        public virtual DbSet<conflict_dbo_data_residentRoom> conflict_dbo_data_residentRoom { get; set; }
        public virtual DbSet<Cus_ProductDistribution> Cus_ProductDistribution { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigresponse> MSpeer_conflictdetectionconfigresponse { get; set; }
        public virtual DbSet<MSpeer_originatorid_history> MSpeer_originatorid_history { get; set; }
        public virtual DbSet<MSpeer_request> MSpeer_request { get; set; }
        public virtual DbSet<MSpeer_response> MSpeer_response { get; set; }
        public virtual DbSet<MSpeer_topologyrequest> MSpeer_topologyrequest { get; set; }
        public virtual DbSet<MSpeer_topologyresponse> MSpeer_topologyresponse { get; set; }
        public virtual DbSet<MSpub_identity_range> MSpub_identity_range { get; set; }
        public virtual DbSet<Sys_Area> Sys_Area { get; set; }
        public virtual DbSet<Sys_Notice> Sys_Notice { get; set; }
        public virtual DbSet<sysarticlecolumns> sysarticlecolumns { get; set; }
        public virtual DbSet<sysarticles> sysarticles { get; set; }
        public virtual DbSet<sysarticleupdates> sysarticleupdates { get; set; }
        public virtual DbSet<syspublications> syspublications { get; set; }
        public virtual DbSet<sysschemaarticles> sysschemaarticles { get; set; }
        public virtual DbSet<syssubscriptions> syssubscriptions { get; set; }
        public virtual DbSet<systranschemas> systranschemas { get; set; }
        public virtual ObjectResult<sys_ParameterValue> proc_sysParamValueSearch(Nullable<int> paramId, Nullable<int> pageSize, Nullable<int> pageIndex, Nullable<bool> noPager, Nullable<bool> showAll, string valueKey, Nullable<int> status, Nullable<System.DateTime> datePoint1, Nullable<System.DateTime> datePoint2, string propertyCode, string conditionValueStr, ObjectParameter allCount)
        {
            var paramIdParameter = paramId.HasValue ?
                new ObjectParameter("ParamId", paramId) :
                new ObjectParameter("ParamId", typeof(int));

            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));

            var pageIndexParameter = pageIndex.HasValue ?
                new ObjectParameter("PageIndex", pageIndex) :
                new ObjectParameter("PageIndex", typeof(int));

            var noPagerParameter = noPager.HasValue ?
                new ObjectParameter("NoPager", noPager) :
                new ObjectParameter("NoPager", typeof(bool));

            var showAllParameter = showAll.HasValue ?
                new ObjectParameter("ShowAll", showAll) :
                new ObjectParameter("ShowAll", typeof(bool));

            var valueKeyParameter = valueKey != null ?
                new ObjectParameter("ValueKey", valueKey) :
                new ObjectParameter("ValueKey", typeof(string));

            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));

            var datePoint1Parameter = datePoint1.HasValue ?
                new ObjectParameter("DatePoint1", datePoint1) :
                new ObjectParameter("DatePoint1", typeof(System.DateTime));

            var datePoint2Parameter = datePoint2.HasValue ?
                new ObjectParameter("DatePoint2", datePoint2) :
                new ObjectParameter("DatePoint2", typeof(System.DateTime));

            var propertyCodeParameter = propertyCode != null ?
                new ObjectParameter("PropertyCode", propertyCode) :
                new ObjectParameter("PropertyCode", typeof(string));

            var conditionValueStrParameter = conditionValueStr != null ?
                new ObjectParameter("ConditionValueStr", conditionValueStr) :
                new ObjectParameter("ConditionValueStr", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sys_ParameterValue>("proc_sysParamValueSearch", paramIdParameter, pageSizeParameter, pageIndexParameter, noPagerParameter, showAllParameter, valueKeyParameter, statusParameter, datePoint1Parameter, datePoint2Parameter, propertyCodeParameter, conditionValueStrParameter, allCount);
        }

        public virtual ObjectResult<sys_ParameterValue> proc_sysParamValueSearch(Nullable<int> paramId, Nullable<int> pageSize, Nullable<int> pageIndex, Nullable<bool> noPager, Nullable<bool> showAll, string valueKey, Nullable<int> status, Nullable<System.DateTime> datePoint1, Nullable<System.DateTime> datePoint2, string propertyCode, string conditionValueStr, ObjectParameter allCount, MergeOption mergeOption)
        {
            var paramIdParameter = paramId.HasValue ?
                new ObjectParameter("ParamId", paramId) :
                new ObjectParameter("ParamId", typeof(int));

            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));

            var pageIndexParameter = pageIndex.HasValue ?
                new ObjectParameter("PageIndex", pageIndex) :
                new ObjectParameter("PageIndex", typeof(int));

            var noPagerParameter = noPager.HasValue ?
                new ObjectParameter("NoPager", noPager) :
                new ObjectParameter("NoPager", typeof(bool));

            var showAllParameter = showAll.HasValue ?
                new ObjectParameter("ShowAll", showAll) :
                new ObjectParameter("ShowAll", typeof(bool));

            var valueKeyParameter = valueKey != null ?
                new ObjectParameter("ValueKey", valueKey) :
                new ObjectParameter("ValueKey", typeof(string));

            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));

            var datePoint1Parameter = datePoint1.HasValue ?
                new ObjectParameter("DatePoint1", datePoint1) :
                new ObjectParameter("DatePoint1", typeof(System.DateTime));

            var datePoint2Parameter = datePoint2.HasValue ?
                new ObjectParameter("DatePoint2", datePoint2) :
                new ObjectParameter("DatePoint2", typeof(System.DateTime));

            var propertyCodeParameter = propertyCode != null ?
                new ObjectParameter("PropertyCode", propertyCode) :
                new ObjectParameter("PropertyCode", typeof(string));

            var conditionValueStrParameter = conditionValueStr != null ?
                new ObjectParameter("ConditionValueStr", conditionValueStr) :
                new ObjectParameter("ConditionValueStr", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sys_ParameterValue>("proc_sysParamValueSearch", mergeOption, paramIdParameter, pageSizeParameter, pageIndexParameter, noPagerParameter, showAllParameter, valueKeyParameter, statusParameter, datePoint1Parameter, datePoint2Parameter, propertyCodeParameter, conditionValueStrParameter, allCount);
        }

        public virtual ObjectResult<sys_ParameterValue> proc_GetParamValueMakePrice(string paramIdList, string propertyCodeList, string conditionList, Nullable<System.DateTime> enableDate, Nullable<int> makePriceType)
        {
            var paramIdListParameter = paramIdList != null ?
                new ObjectParameter("ParamIdList", paramIdList) :
                new ObjectParameter("ParamIdList", typeof(string));

            var propertyCodeListParameter = propertyCodeList != null ?
                new ObjectParameter("PropertyCodeList", propertyCodeList) :
                new ObjectParameter("PropertyCodeList", typeof(string));

            var conditionListParameter = conditionList != null ?
                new ObjectParameter("ConditionList", conditionList) :
                new ObjectParameter("ConditionList", typeof(string));

            var enableDateParameter = enableDate.HasValue ?
                new ObjectParameter("EnableDate", enableDate) :
                new ObjectParameter("EnableDate", typeof(System.DateTime));

            var makePriceTypeParameter = makePriceType.HasValue ?
                new ObjectParameter("MakePriceType", makePriceType) :
                new ObjectParameter("MakePriceType", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sys_ParameterValue>("proc_GetParamValueMakePrice", paramIdListParameter, propertyCodeListParameter, conditionListParameter, enableDateParameter, makePriceTypeParameter);
        }

        public virtual ObjectResult<sys_ParameterValue> proc_GetParamValueMakePrice(string paramIdList, string propertyCodeList, string conditionList, Nullable<System.DateTime> enableDate, Nullable<int> makePriceType, MergeOption mergeOption)
        {
            var paramIdListParameter = paramIdList != null ?
                new ObjectParameter("ParamIdList", paramIdList) :
                new ObjectParameter("ParamIdList", typeof(string));

            var propertyCodeListParameter = propertyCodeList != null ?
                new ObjectParameter("PropertyCodeList", propertyCodeList) :
                new ObjectParameter("PropertyCodeList", typeof(string));

            var conditionListParameter = conditionList != null ?
                new ObjectParameter("ConditionList", conditionList) :
                new ObjectParameter("ConditionList", typeof(string));

            var enableDateParameter = enableDate.HasValue ?
                new ObjectParameter("EnableDate", enableDate) :
                new ObjectParameter("EnableDate", typeof(System.DateTime));

            var makePriceTypeParameter = makePriceType.HasValue ?
                new ObjectParameter("MakePriceType", makePriceType) :
                new ObjectParameter("MakePriceType", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sys_ParameterValue>("proc_GetParamValueMakePrice", mergeOption, paramIdListParameter, propertyCodeListParameter, conditionListParameter, enableDateParameter, makePriceTypeParameter);
        }
    }
}