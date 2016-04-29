  //引进TT模板的命名空间

//使用TT模板生成代码的片段
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Model;

namespace Service.IBLL
{

	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
	 public partial interface Iconflict_dbo_data_officeFloorService:IBaseService<conflict_dbo_data_officeFloor>
    {
	}
	 public partial interface Iconflict_dbo_data_officeProjectService:IBaseService<conflict_dbo_data_officeProject>
    {
	}
	 public partial interface Iconflict_dbo_data_officeRoomService:IBaseService<conflict_dbo_data_officeRoom>
    {
	}
	 public partial interface Iconflict_dbo_data_residentFloorService:IBaseService<conflict_dbo_data_residentFloor>
    {
	}
	 public partial interface Iconflict_dbo_data_residentProjectService:IBaseService<conflict_dbo_data_residentProject>
    {
	}
	 public partial interface Iconflict_dbo_data_residentRoomService:IBaseService<conflict_dbo_data_residentRoom>
    {
	}
	 public partial interface ICus_AppraisalInstitutionService:IBaseService<Cus_AppraisalInstitution>
    {
	}
	 public partial interface ICus_AreaDistributionService:IBaseService<Cus_AreaDistribution>
    {
	}
	 public partial interface ICus_BranchService:IBaseService<Cus_Branch>
    {
	}
	 public partial interface ICus_CompanyService:IBaseService<Cus_Company>
    {
	}
	 public partial interface ICus_ConfigService:IBaseService<Cus_Config>
    {
	}
	 public partial interface ICus_IsQueryService:IBaseService<Cus_IsQuery>
    {
	}
	 public partial interface ICus_OrganizationService:IBaseService<Cus_Organization>
    {
	}
	 public partial interface ICus_PostService:IBaseService<Cus_Post>
    {
	}
	 public partial interface ICus_PriceResultConfigService:IBaseService<Cus_PriceResultConfig>
    {
	}
	 public partial interface ICus_ProductDistributionService:IBaseService<Cus_ProductDistribution>
    {
	}
	 public partial interface ICus_PropertyDistributionService:IBaseService<Cus_PropertyDistribution>
    {
	}
	 public partial interface ICus_RoleService:IBaseService<Cus_Role>
    {
	}
	 public partial interface ICus_RoleMenuService:IBaseService<Cus_RoleMenu>
    {
	}
	 public partial interface ICus_RoleUserService:IBaseService<Cus_RoleUser>
    {
	}
	 public partial interface ICus_ServiceAreaService:IBaseService<Cus_ServiceArea>
    {
	}
	 public partial interface ICus_TempletDistributionService:IBaseService<Cus_TempletDistribution>
    {
	}
	 public partial interface ICus_UserService:IBaseService<Cus_User>
    {
	}
	 public partial interface Idata_attachmentService:IBaseService<data_attachment>
    {
	}
	 public partial interface Idata_baseInfoAllFieldsService:IBaseService<data_baseInfoAllFields>
    {
	}
	 public partial interface Idata_baseInfoGroupService:IBaseService<data_baseInfoGroup>
    {
	}
	 public partial interface Idata_baseInfoGroupFieldsService:IBaseService<data_baseInfoGroupFields>
    {
	}
	 public partial interface Idata_BuildingTargetService:IBaseService<data_BuildingTarget>
    {
	}
	 public partial interface Idata_HousingCaseService:IBaseService<data_HousingCase>
    {
	}
	 public partial interface Idata_HousingLeaseCaseService:IBaseService<data_HousingLeaseCase>
    {
	}
	 public partial interface Idata_makePriceListService:IBaseService<data_makePriceList>
    {
	}
	 public partial interface Idata_makePriceListDetailService:IBaseService<data_makePriceListDetail>
    {
	}
	 public partial interface Idata_makePriceListMethodService:IBaseService<data_makePriceListMethod>
    {
	}
	 public partial interface Idata_makePriceListObjectService:IBaseService<data_makePriceListObject>
    {
	}
	 public partial interface Idata_makePriceListObjectTempService:IBaseService<data_makePriceListObjectTemp>
    {
	}
	 public partial interface Idata_makePriceListProcessService:IBaseService<data_makePriceListProcess>
    {
	}
	 public partial interface Idata_makePriceListResultService:IBaseService<data_makePriceListResult>
    {
	}
	 public partial interface Idata_MakePriceSubmitLogService:IBaseService<data_MakePriceSubmitLog>
    {
	}
	 public partial interface Idata_NewsBulletinInfoService:IBaseService<data_NewsBulletinInfo>
    {
	}
	 public partial interface Idata_OfficeBuildingsCaseService:IBaseService<data_OfficeBuildingsCase>
    {
	}
	 public partial interface Idata_OfficeBuildingsLeaseCaseService:IBaseService<data_OfficeBuildingsLeaseCase>
    {
	}
	 public partial interface Idata_officeFloorService:IBaseService<data_officeFloor>
    {
	}
	 public partial interface Idata_officeFloorPriceService:IBaseService<data_officeFloorPrice>
    {
	}
	 public partial interface Idata_officeFloorPriceTempService:IBaseService<data_officeFloorPriceTemp>
    {
	}
	 public partial interface Idata_officeFloorTempService:IBaseService<data_officeFloorTemp>
    {
	}
	 public partial interface Idata_officeFloorUpdateSolrService:IBaseService<data_officeFloorUpdateSolr>
    {
	}
	 public partial interface Idata_officeProjectService:IBaseService<data_officeProject>
    {
	}
	 public partial interface Idata_officeProjectPriceService:IBaseService<data_officeProjectPrice>
    {
	}
	 public partial interface Idata_officeProjectPriceTempService:IBaseService<data_officeProjectPriceTemp>
    {
	}
	 public partial interface Idata_officeProjectPropertyTypeService:IBaseService<data_officeProjectPropertyType>
    {
	}
	 public partial interface Idata_officeProjectSummaryPriceService:IBaseService<data_officeProjectSummaryPrice>
    {
	}
	 public partial interface Idata_officeProjectTempService:IBaseService<data_officeProjectTemp>
    {
	}
	 public partial interface Idata_officeProjectUpdateSolrService:IBaseService<data_officeProjectUpdateSolr>
    {
	}
	 public partial interface Idata_officeRoomService:IBaseService<data_officeRoom>
    {
	}
	 public partial interface Idata_officeRoomPriceService:IBaseService<data_officeRoomPrice>
    {
	}
	 public partial interface Idata_officeRoomPriceTempService:IBaseService<data_officeRoomPriceTemp>
    {
	}
	 public partial interface Idata_officeRoomTempService:IBaseService<data_officeRoomTemp>
    {
	}
	 public partial interface Idata_officeRoomUpdateSolrService:IBaseService<data_officeRoomUpdateSolr>
    {
	}
	 public partial interface Idata_opinionLibraryService:IBaseService<data_opinionLibrary>
    {
	}
	 public partial interface Idata_pictureTypeService:IBaseService<data_pictureType>
    {
	}
	 public partial interface Idata_residentFloorService:IBaseService<data_residentFloor>
    {
	}
	 public partial interface Idata_residentFloorPriceService:IBaseService<data_residentFloorPrice>
    {
	}
	 public partial interface Idata_residentFloorPriceTempService:IBaseService<data_residentFloorPriceTemp>
    {
	}
	 public partial interface Idata_residentFloorSettingService:IBaseService<data_residentFloorSetting>
    {
	}
	 public partial interface Idata_residentFloorTempService:IBaseService<data_residentFloorTemp>
    {
	}
	 public partial interface Idata_residentFloorUpdateSolrService:IBaseService<data_residentFloorUpdateSolr>
    {
	}
	 public partial interface Idata_residentProjectService:IBaseService<data_residentProject>
    {
	}
	 public partial interface Idata_residentProjectCashabilityService:IBaseService<data_residentProjectCashability>
    {
	}
	 public partial interface Idata_residentProjectPriceService:IBaseService<data_residentProjectPrice>
    {
	}
	 public partial interface Idata_residentProjectPriceTempService:IBaseService<data_residentProjectPriceTemp>
    {
	}
	 public partial interface Idata_residentProjectPropertyTypeService:IBaseService<data_residentProjectPropertyType>
    {
	}
	 public partial interface Idata_residentProjectSummaryPriceService:IBaseService<data_residentProjectSummaryPrice>
    {
	}
	 public partial interface Idata_residentProjectTempService:IBaseService<data_residentProjectTemp>
    {
	}
	 public partial interface Idata_residentProjectUpdateSolrService:IBaseService<data_residentProjectUpdateSolr>
    {
	}
	 public partial interface Idata_residentRoomService:IBaseService<data_residentRoom>
    {
	}
	 public partial interface Idata_residentRoomPriceService:IBaseService<data_residentRoomPrice>
    {
	}
	 public partial interface Idata_residentRoomPriceTempService:IBaseService<data_residentRoomPriceTemp>
    {
	}
	 public partial interface Idata_residentRoomSettingService:IBaseService<data_residentRoomSetting>
    {
	}
	 public partial interface Idata_residentRoomTempService:IBaseService<data_residentRoomTemp>
    {
	}
	 public partial interface Idata_residentRoomUpdateSolrService:IBaseService<data_residentRoomUpdateSolr>
    {
	}
	 public partial interface Idata_residentTradeCaseService:IBaseService<data_residentTradeCase>
    {
	}
	 public partial interface Idata_uploadDirectoryService:IBaseService<data_uploadDirectory>
    {
	}
	 public partial interface IEstateStatitsticsService:IBaseService<EstateStatitstics>
    {
	}
	 public partial interface IFloorFittedDataService:IBaseService<FloorFittedData>
    {
	}
	 public partial interface IFloorPriceChangeRatioDataService:IBaseService<FloorPriceChangeRatioData>
    {
	}
	 public partial interface IFloorSmoothDataService:IBaseService<FloorSmoothData>
    {
	}
	 public partial interface IMSpeer_conflictdetectionconfigrequestService:IBaseService<MSpeer_conflictdetectionconfigrequest>
    {
	}
	 public partial interface IMSpeer_conflictdetectionconfigresponseService:IBaseService<MSpeer_conflictdetectionconfigresponse>
    {
	}
	 public partial interface IMSpeer_lsnsService:IBaseService<MSpeer_lsns>
    {
	}
	 public partial interface IMSpeer_originatorid_historyService:IBaseService<MSpeer_originatorid_history>
    {
	}
	 public partial interface IMSpeer_requestService:IBaseService<MSpeer_request>
    {
	}
	 public partial interface IMSpeer_responseService:IBaseService<MSpeer_response>
    {
	}
	 public partial interface IMSpeer_topologyrequestService:IBaseService<MSpeer_topologyrequest>
    {
	}
	 public partial interface IMSpeer_topologyresponseService:IBaseService<MSpeer_topologyresponse>
    {
	}
	 public partial interface IMSpub_identity_rangeService:IBaseService<MSpub_identity_range>
    {
	}
	 public partial interface IProjectFittedDataService:IBaseService<ProjectFittedData>
    {
	}
	 public partial interface IProjectPriceChangeRatioDataService:IBaseService<ProjectPriceChangeRatioData>
    {
	}
	 public partial interface IProjectSmoothDataService:IBaseService<ProjectSmoothData>
    {
	}
	 public partial interface IRoomFittedDataService:IBaseService<RoomFittedData>
    {
	}
	 public partial interface IRoomPriceChangeRatioDataService:IBaseService<RoomPriceChangeRatioData>
    {
	}
	 public partial interface IRoomSmoothDataService:IBaseService<RoomSmoothData>
    {
	}
	 public partial interface Isys_applicationService:IBaseService<sys_application>
    {
	}
	 public partial interface ISys_AreaService:IBaseService<Sys_Area>
    {
	}
	 public partial interface Isys_CAADMethodService:IBaseService<sys_CAADMethod>
    {
	}
	 public partial interface Isys_CAADMethodPropertyService:IBaseService<sys_CAADMethodProperty>
    {
	}
	 public partial interface Isys_CusOrgRelationService:IBaseService<sys_CusOrgRelation>
    {
	}
	 public partial interface Isys_dictService:IBaseService<sys_dict>
    {
	}
	 public partial interface Isys_dictOrganizeService:IBaseService<sys_dictOrganize>
    {
	}
	 public partial interface Isys_dictTypeService:IBaseService<sys_dictType>
    {
	}
	 public partial interface Isys_employeeService:IBaseService<sys_employee>
    {
	}
	 public partial interface Isys_fucGroupService:IBaseService<sys_fucGroup>
    {
	}
	 public partial interface Isys_functionService:IBaseService<sys_function>
    {
	}
	 public partial interface Isys_generateRuleService:IBaseService<sys_generateRule>
    {
	}
	 public partial interface Isys_gisService:IBaseService<sys_gis>
    {
	}
	 public partial interface ISys_GlossaryService:IBaseService<Sys_Glossary>
    {
	}
	 public partial interface Isys_HelpContentService:IBaseService<sys_HelpContent>
    {
	}
	 public partial interface Isys_HelpGroupService:IBaseService<sys_HelpGroup>
    {
	}
	 public partial interface Isys_IsQueryService:IBaseService<sys_IsQuery>
    {
	}
	 public partial interface Isys_jobsService:IBaseService<sys_jobs>
    {
	}
	 public partial interface Isys_MakePriceMethodService:IBaseService<sys_MakePriceMethod>
    {
	}
	 public partial interface Isys_MakePriceQueryService:IBaseService<sys_MakePriceQuery>
    {
	}
	 public partial interface Isys_MakePriceTemplateService:IBaseService<sys_MakePriceTemplate>
    {
	}
	 public partial interface Isys_menuService:IBaseService<sys_menu>
    {
	}
	 public partial interface Isys_MethodTitleService:IBaseService<sys_MethodTitle>
    {
	}
	 public partial interface ISys_NoticeService:IBaseService<Sys_Notice>
    {
	}
	 public partial interface Isys_organizeService:IBaseService<sys_organize>
    {
	}
	 public partial interface Isys_organize_bakService:IBaseService<sys_organize_bak>
    {
	}
	 public partial interface Isys_OrganizeMakePriceMethodService:IBaseService<sys_OrganizeMakePriceMethod>
    {
	}
	 public partial interface Isys_ParameterService:IBaseService<sys_Parameter>
    {
	}
	 public partial interface Isys_ParameterConditionService:IBaseService<sys_ParameterCondition>
    {
	}
	 public partial interface Isys_ParameterConditionValueService:IBaseService<sys_ParameterConditionValue>
    {
	}
	 public partial interface Isys_ParameterScoreService:IBaseService<sys_ParameterScore>
    {
	}
	 public partial interface Isys_ParameterScoreValueService:IBaseService<sys_ParameterScoreValue>
    {
	}
	 public partial interface Isys_ParameterSettingService:IBaseService<sys_ParameterSetting>
    {
	}
	 public partial interface Isys_ParameterValueService:IBaseService<sys_ParameterValue>
    {
	}
	 public partial interface Isys_plateInfoService:IBaseService<sys_plateInfo>
    {
	}
	 public partial interface Isys_PriceProportionService:IBaseService<sys_PriceProportion>
    {
	}
	 public partial interface Isys_ProductService:IBaseService<sys_Product>
    {
	}
	 public partial interface Isys_ProductAuthorizationService:IBaseService<sys_ProductAuthorization>
    {
	}
	 public partial interface Isys_propertyPlateCollectsService:IBaseService<sys_propertyPlateCollects>
    {
	}
	 public partial interface Isys_propertyTypeConditionService:IBaseService<sys_propertyTypeCondition>
    {
	}
	 public partial interface Isys_propertyTypeValueService:IBaseService<sys_propertyTypeValue>
    {
	}
	 public partial interface Isys_propertyTypeValueOrganizationService:IBaseService<sys_propertyTypeValueOrganization>
    {
	}
	 public partial interface Isys_roleService:IBaseService<sys_role>
    {
	}
	 public partial interface Isys_roleMenuService:IBaseService<sys_roleMenu>
    {
	}
	 public partial interface Isys_roleUserService:IBaseService<sys_roleUser>
    {
	}
	 public partial interface Isys_TaxService:IBaseService<sys_Tax>
    {
	}
	 public partial interface Isys_UsageLogService:IBaseService<sys_UsageLog>
    {
	}
	 public partial interface Isys_userService:IBaseService<sys_user>
    {
	}
	 public partial interface Isys_userTemplateService:IBaseService<sys_userTemplate>
    {
	}
	 public partial interface IsysarticlecolumnsService:IBaseService<sysarticlecolumns>
    {
	}
	 public partial interface IsysarticlesService:IBaseService<sysarticles>
    {
	}
	 public partial interface IsysarticleupdatesService:IBaseService<sysarticleupdates>
    {
	}
	 public partial interface IsysdiagramsService:IBaseService<sysdiagrams>
    {
	}
	 public partial interface IsyspublicationsService:IBaseService<syspublications>
    {
	}
	 public partial interface IsysreplserversService:IBaseService<sysreplservers>
    {
	}
	 public partial interface IsysschemaarticlesService:IBaseService<sysschemaarticles>
    {
	}
	 public partial interface IsyssubscriptionsService:IBaseService<syssubscriptions>
    {
	}
	 public partial interface IsystranschemasService:IBaseService<systranschemas>
    {
	}
}