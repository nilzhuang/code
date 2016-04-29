  //引进TT模板的命名空间

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.IDAL;

namespace Service.DAL
{
    //一次跟数据库交互的会话
    public partial class DbSession : IDbSession //代表应用程序跟数据库之间的一次会话，也是数据库访问层的统一入口
    {


	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
		        public IDAL.ICus_AppraisalInstitutionRepository Cus_AppraisalInstitutionRepository
			{
				get { return new Cus_AppraisalInstitutionRepository(this); }
			}
		        public IDAL.ICus_AreaDistributionRepository Cus_AreaDistributionRepository
			{
				get { return new Cus_AreaDistributionRepository(this); }
			}
		        public IDAL.ICus_BranchRepository Cus_BranchRepository
			{
				get { return new Cus_BranchRepository(this); }
			}
		        public IDAL.ICus_CompanyRepository Cus_CompanyRepository
			{
				get { return new Cus_CompanyRepository(this); }
			}
		        public IDAL.ICus_ConfigRepository Cus_ConfigRepository
			{
				get { return new Cus_ConfigRepository(this); }
			}
		        public IDAL.ICus_IsQueryRepository Cus_IsQueryRepository
			{
				get { return new Cus_IsQueryRepository(this); }
			}
		        public IDAL.ICus_OrganizationRepository Cus_OrganizationRepository
			{
				get { return new Cus_OrganizationRepository(this); }
			}
		        public IDAL.ICus_PostRepository Cus_PostRepository
			{
				get { return new Cus_PostRepository(this); }
			}
		        public IDAL.ICus_PriceResultConfigRepository Cus_PriceResultConfigRepository
			{
				get { return new Cus_PriceResultConfigRepository(this); }
			}
		        public IDAL.ICus_ProductDistributionRepository Cus_ProductDistributionRepository
			{
				get { return new Cus_ProductDistributionRepository(this); }
			}
		        public IDAL.ICus_PropertyDistributionRepository Cus_PropertyDistributionRepository
			{
				get { return new Cus_PropertyDistributionRepository(this); }
			}
		        public IDAL.ICus_RoleRepository Cus_RoleRepository
			{
				get { return new Cus_RoleRepository(this); }
			}
		        public IDAL.ICus_RoleMenuRepository Cus_RoleMenuRepository
			{
				get { return new Cus_RoleMenuRepository(this); }
			}
		        public IDAL.ICus_RoleUserRepository Cus_RoleUserRepository
			{
				get { return new Cus_RoleUserRepository(this); }
			}
		        public IDAL.ICus_ServiceAreaRepository Cus_ServiceAreaRepository
			{
				get { return new Cus_ServiceAreaRepository(this); }
			}
		        public IDAL.ICus_TempletDistributionRepository Cus_TempletDistributionRepository
			{
				get { return new Cus_TempletDistributionRepository(this); }
			}
		        public IDAL.ICus_UserRepository Cus_UserRepository
			{
				get { return new Cus_UserRepository(this); }
			}
		        public IDAL.Idata_attachmentRepository data_attachmentRepository
			{
				get { return new data_attachmentRepository(this); }
			}
		        public IDAL.Idata_baseInfoAllFieldsRepository data_baseInfoAllFieldsRepository
			{
				get { return new data_baseInfoAllFieldsRepository(this); }
			}
		        public IDAL.Idata_baseInfoGroupRepository data_baseInfoGroupRepository
			{
				get { return new data_baseInfoGroupRepository(this); }
			}
		        public IDAL.Idata_baseInfoGroupFieldsRepository data_baseInfoGroupFieldsRepository
			{
				get { return new data_baseInfoGroupFieldsRepository(this); }
			}
		        public IDAL.Idata_BuildingTargetRepository data_BuildingTargetRepository
			{
				get { return new data_BuildingTargetRepository(this); }
			}
		        public IDAL.Idata_HousingCaseRepository data_HousingCaseRepository
			{
				get { return new data_HousingCaseRepository(this); }
			}
		        public IDAL.Idata_HousingLeaseCaseRepository data_HousingLeaseCaseRepository
			{
				get { return new data_HousingLeaseCaseRepository(this); }
			}
		        public IDAL.Idata_makePriceListRepository data_makePriceListRepository
			{
				get { return new data_makePriceListRepository(this); }
			}
		        public IDAL.Idata_makePriceListDetailRepository data_makePriceListDetailRepository
			{
				get { return new data_makePriceListDetailRepository(this); }
			}
		        public IDAL.Idata_makePriceListMethodRepository data_makePriceListMethodRepository
			{
				get { return new data_makePriceListMethodRepository(this); }
			}
		        public IDAL.Idata_makePriceListObjectRepository data_makePriceListObjectRepository
			{
				get { return new data_makePriceListObjectRepository(this); }
			}
		        public IDAL.Idata_makePriceListObjectTempRepository data_makePriceListObjectTempRepository
			{
				get { return new data_makePriceListObjectTempRepository(this); }
			}
		        public IDAL.Idata_makePriceListProcessRepository data_makePriceListProcessRepository
			{
				get { return new data_makePriceListProcessRepository(this); }
			}
		        public IDAL.Idata_makePriceListResultRepository data_makePriceListResultRepository
			{
				get { return new data_makePriceListResultRepository(this); }
			}
		        public IDAL.Idata_MakePriceSubmitLogRepository data_MakePriceSubmitLogRepository
			{
				get { return new data_MakePriceSubmitLogRepository(this); }
			}
		        public IDAL.Idata_NewsBulletinInfoRepository data_NewsBulletinInfoRepository
			{
				get { return new data_NewsBulletinInfoRepository(this); }
			}
		        public IDAL.Idata_OfficeBuildingsCaseRepository data_OfficeBuildingsCaseRepository
			{
				get { return new data_OfficeBuildingsCaseRepository(this); }
			}
		        public IDAL.Idata_OfficeBuildingsLeaseCaseRepository data_OfficeBuildingsLeaseCaseRepository
			{
				get { return new data_OfficeBuildingsLeaseCaseRepository(this); }
			}
		        public IDAL.Idata_officeFloorRepository data_officeFloorRepository
			{
				get { return new data_officeFloorRepository(this); }
			}
		        public IDAL.Idata_officeFloorPriceRepository data_officeFloorPriceRepository
			{
				get { return new data_officeFloorPriceRepository(this); }
			}
		        public IDAL.Idata_officeFloorPriceTempRepository data_officeFloorPriceTempRepository
			{
				get { return new data_officeFloorPriceTempRepository(this); }
			}
		        public IDAL.Idata_officeFloorTempRepository data_officeFloorTempRepository
			{
				get { return new data_officeFloorTempRepository(this); }
			}
		        public IDAL.Idata_officeFloorUpdateSolrRepository data_officeFloorUpdateSolrRepository
			{
				get { return new data_officeFloorUpdateSolrRepository(this); }
			}
		        public IDAL.Idata_officeProjectRepository data_officeProjectRepository
			{
				get { return new data_officeProjectRepository(this); }
			}
		        public IDAL.Idata_officeProjectPriceRepository data_officeProjectPriceRepository
			{
				get { return new data_officeProjectPriceRepository(this); }
			}
		        public IDAL.Idata_officeProjectPriceTempRepository data_officeProjectPriceTempRepository
			{
				get { return new data_officeProjectPriceTempRepository(this); }
			}
		        public IDAL.Idata_officeProjectPropertyTypeRepository data_officeProjectPropertyTypeRepository
			{
				get { return new data_officeProjectPropertyTypeRepository(this); }
			}
		        public IDAL.Idata_officeProjectSummaryPriceRepository data_officeProjectSummaryPriceRepository
			{
				get { return new data_officeProjectSummaryPriceRepository(this); }
			}
		        public IDAL.Idata_officeProjectTempRepository data_officeProjectTempRepository
			{
				get { return new data_officeProjectTempRepository(this); }
			}
		        public IDAL.Idata_officeProjectUpdateSolrRepository data_officeProjectUpdateSolrRepository
			{
				get { return new data_officeProjectUpdateSolrRepository(this); }
			}
		        public IDAL.Idata_officeRoomRepository data_officeRoomRepository
			{
				get { return new data_officeRoomRepository(this); }
			}
		        public IDAL.Idata_officeRoomPriceRepository data_officeRoomPriceRepository
			{
				get { return new data_officeRoomPriceRepository(this); }
			}
		        public IDAL.Idata_officeRoomPriceTempRepository data_officeRoomPriceTempRepository
			{
				get { return new data_officeRoomPriceTempRepository(this); }
			}
		        public IDAL.Idata_officeRoomTempRepository data_officeRoomTempRepository
			{
				get { return new data_officeRoomTempRepository(this); }
			}
		        public IDAL.Idata_officeRoomUpdateSolrRepository data_officeRoomUpdateSolrRepository
			{
				get { return new data_officeRoomUpdateSolrRepository(this); }
			}
		        public IDAL.Idata_opinionLibraryRepository data_opinionLibraryRepository
			{
				get { return new data_opinionLibraryRepository(this); }
			}
		        public IDAL.Idata_pictureTypeRepository data_pictureTypeRepository
			{
				get { return new data_pictureTypeRepository(this); }
			}
		        public IDAL.Idata_residentFloorRepository data_residentFloorRepository
			{
				get { return new data_residentFloorRepository(this); }
			}
		        public IDAL.Idata_residentFloorPriceRepository data_residentFloorPriceRepository
			{
				get { return new data_residentFloorPriceRepository(this); }
			}
		        public IDAL.Idata_residentFloorPriceTempRepository data_residentFloorPriceTempRepository
			{
				get { return new data_residentFloorPriceTempRepository(this); }
			}
		        public IDAL.Idata_residentFloorSettingRepository data_residentFloorSettingRepository
			{
				get { return new data_residentFloorSettingRepository(this); }
			}
		        public IDAL.Idata_residentFloorTempRepository data_residentFloorTempRepository
			{
				get { return new data_residentFloorTempRepository(this); }
			}
		        public IDAL.Idata_residentFloorUpdateSolrRepository data_residentFloorUpdateSolrRepository
			{
				get { return new data_residentFloorUpdateSolrRepository(this); }
			}
		        public IDAL.Idata_residentProjectRepository data_residentProjectRepository
			{
				get { return new data_residentProjectRepository(this); }
			}
		        public IDAL.Idata_residentProjectCashabilityRepository data_residentProjectCashabilityRepository
			{
				get { return new data_residentProjectCashabilityRepository(this); }
			}
		        public IDAL.Idata_residentProjectPriceRepository data_residentProjectPriceRepository
			{
				get { return new data_residentProjectPriceRepository(this); }
			}
		        public IDAL.Idata_residentProjectPriceTempRepository data_residentProjectPriceTempRepository
			{
				get { return new data_residentProjectPriceTempRepository(this); }
			}
		        public IDAL.Idata_residentProjectPropertyTypeRepository data_residentProjectPropertyTypeRepository
			{
				get { return new data_residentProjectPropertyTypeRepository(this); }
			}
		        public IDAL.Idata_residentProjectSummaryPriceRepository data_residentProjectSummaryPriceRepository
			{
				get { return new data_residentProjectSummaryPriceRepository(this); }
			}
		        public IDAL.Idata_residentProjectTempRepository data_residentProjectTempRepository
			{
				get { return new data_residentProjectTempRepository(this); }
			}
		        public IDAL.Idata_residentProjectUpdateSolrRepository data_residentProjectUpdateSolrRepository
			{
				get { return new data_residentProjectUpdateSolrRepository(this); }
			}
		        public IDAL.Idata_residentRoomRepository data_residentRoomRepository
			{
				get { return new data_residentRoomRepository(this); }
			}
		        public IDAL.Idata_residentRoomPriceRepository data_residentRoomPriceRepository
			{
				get { return new data_residentRoomPriceRepository(this); }
			}
		        public IDAL.Idata_residentRoomPriceTempRepository data_residentRoomPriceTempRepository
			{
				get { return new data_residentRoomPriceTempRepository(this); }
			}
		        public IDAL.Idata_residentRoomSettingRepository data_residentRoomSettingRepository
			{
				get { return new data_residentRoomSettingRepository(this); }
			}
		        public IDAL.Idata_residentRoomTempRepository data_residentRoomTempRepository
			{
				get { return new data_residentRoomTempRepository(this); }
			}
		        public IDAL.Idata_residentRoomUpdateSolrRepository data_residentRoomUpdateSolrRepository
			{
				get { return new data_residentRoomUpdateSolrRepository(this); }
			}
		        public IDAL.Idata_residentTradeCaseRepository data_residentTradeCaseRepository
			{
				get { return new data_residentTradeCaseRepository(this); }
			}
		        public IDAL.Idata_uploadDirectoryRepository data_uploadDirectoryRepository
			{
				get { return new data_uploadDirectoryRepository(this); }
			}
		        public IDAL.IEstateStatitsticsRepository EstateStatitsticsRepository
			{
				get { return new EstateStatitsticsRepository(this); }
			}
		        public IDAL.IFloorFittedDataRepository FloorFittedDataRepository
			{
				get { return new FloorFittedDataRepository(this); }
			}
		        public IDAL.IFloorPriceChangeRatioDataRepository FloorPriceChangeRatioDataRepository
			{
				get { return new FloorPriceChangeRatioDataRepository(this); }
			}
		        public IDAL.IFloorSmoothDataRepository FloorSmoothDataRepository
			{
				get { return new FloorSmoothDataRepository(this); }
			}
		        public IDAL.IMSpeer_conflictdetectionconfigrequestRepository MSpeer_conflictdetectionconfigrequestRepository
			{
				get { return new MSpeer_conflictdetectionconfigrequestRepository(this); }
			}
		        public IDAL.IMSpeer_conflictdetectionconfigresponseRepository MSpeer_conflictdetectionconfigresponseRepository
			{
				get { return new MSpeer_conflictdetectionconfigresponseRepository(this); }
			}
		        public IDAL.IMSpeer_lsnsRepository MSpeer_lsnsRepository
			{
				get { return new MSpeer_lsnsRepository(this); }
			}
		        public IDAL.IMSpeer_originatorid_historyRepository MSpeer_originatorid_historyRepository
			{
				get { return new MSpeer_originatorid_historyRepository(this); }
			}
		        public IDAL.IMSpeer_requestRepository MSpeer_requestRepository
			{
				get { return new MSpeer_requestRepository(this); }
			}
		        public IDAL.IMSpeer_responseRepository MSpeer_responseRepository
			{
				get { return new MSpeer_responseRepository(this); }
			}
		        public IDAL.IMSpeer_topologyrequestRepository MSpeer_topologyrequestRepository
			{
				get { return new MSpeer_topologyrequestRepository(this); }
			}
		        public IDAL.IMSpeer_topologyresponseRepository MSpeer_topologyresponseRepository
			{
				get { return new MSpeer_topologyresponseRepository(this); }
			}
		        public IDAL.IMSpub_identity_rangeRepository MSpub_identity_rangeRepository
			{
				get { return new MSpub_identity_rangeRepository(this); }
			}
		        public IDAL.IProjectFittedDataRepository ProjectFittedDataRepository
			{
				get { return new ProjectFittedDataRepository(this); }
			}
		        public IDAL.IProjectPriceChangeRatioDataRepository ProjectPriceChangeRatioDataRepository
			{
				get { return new ProjectPriceChangeRatioDataRepository(this); }
			}
		        public IDAL.IProjectSmoothDataRepository ProjectSmoothDataRepository
			{
				get { return new ProjectSmoothDataRepository(this); }
			}
		        public IDAL.IRoomFittedDataRepository RoomFittedDataRepository
			{
				get { return new RoomFittedDataRepository(this); }
			}
		        public IDAL.IRoomPriceChangeRatioDataRepository RoomPriceChangeRatioDataRepository
			{
				get { return new RoomPriceChangeRatioDataRepository(this); }
			}
		        public IDAL.IRoomSmoothDataRepository RoomSmoothDataRepository
			{
				get { return new RoomSmoothDataRepository(this); }
			}
		        public IDAL.Isys_applicationRepository sys_applicationRepository
			{
				get { return new sys_applicationRepository(this); }
			}
		        public IDAL.ISys_AreaRepository Sys_AreaRepository
			{
				get { return new Sys_AreaRepository(this); }
			}
		        public IDAL.Isys_CAADMethodRepository sys_CAADMethodRepository
			{
				get { return new sys_CAADMethodRepository(this); }
			}
		        public IDAL.Isys_CAADMethodPropertyRepository sys_CAADMethodPropertyRepository
			{
				get { return new sys_CAADMethodPropertyRepository(this); }
			}
		        public IDAL.Isys_CusOrgRelationRepository sys_CusOrgRelationRepository
			{
				get { return new sys_CusOrgRelationRepository(this); }
			}
		        public IDAL.Isys_dictRepository sys_dictRepository
			{
				get { return new sys_dictRepository(this); }
			}
		        public IDAL.Isys_dictOrganizeRepository sys_dictOrganizeRepository
			{
				get { return new sys_dictOrganizeRepository(this); }
			}
		        public IDAL.Isys_dictTypeRepository sys_dictTypeRepository
			{
				get { return new sys_dictTypeRepository(this); }
			}
		        public IDAL.Isys_employeeRepository sys_employeeRepository
			{
				get { return new sys_employeeRepository(this); }
			}
		        public IDAL.Isys_fucGroupRepository sys_fucGroupRepository
			{
				get { return new sys_fucGroupRepository(this); }
			}
		        public IDAL.Isys_functionRepository sys_functionRepository
			{
				get { return new sys_functionRepository(this); }
			}
		        public IDAL.Isys_generateRuleRepository sys_generateRuleRepository
			{
				get { return new sys_generateRuleRepository(this); }
			}
		        public IDAL.Isys_gisRepository sys_gisRepository
			{
				get { return new sys_gisRepository(this); }
			}
		        public IDAL.ISys_GlossaryRepository Sys_GlossaryRepository
			{
				get { return new Sys_GlossaryRepository(this); }
			}
		        public IDAL.Isys_HelpContentRepository sys_HelpContentRepository
			{
				get { return new sys_HelpContentRepository(this); }
			}
		        public IDAL.Isys_HelpGroupRepository sys_HelpGroupRepository
			{
				get { return new sys_HelpGroupRepository(this); }
			}
		        public IDAL.Isys_IsQueryRepository sys_IsQueryRepository
			{
				get { return new sys_IsQueryRepository(this); }
			}
		        public IDAL.Isys_jobsRepository sys_jobsRepository
			{
				get { return new sys_jobsRepository(this); }
			}
		        public IDAL.Isys_MakePriceMethodRepository sys_MakePriceMethodRepository
			{
				get { return new sys_MakePriceMethodRepository(this); }
			}
		        public IDAL.Isys_MakePriceQueryRepository sys_MakePriceQueryRepository
			{
				get { return new sys_MakePriceQueryRepository(this); }
			}
		        public IDAL.Isys_MakePriceTemplateRepository sys_MakePriceTemplateRepository
			{
				get { return new sys_MakePriceTemplateRepository(this); }
			}
		        public IDAL.Isys_menuRepository sys_menuRepository
			{
				get { return new sys_menuRepository(this); }
			}
		        public IDAL.Isys_MethodTitleRepository sys_MethodTitleRepository
			{
				get { return new sys_MethodTitleRepository(this); }
			}
		        public IDAL.ISys_NoticeRepository Sys_NoticeRepository
			{
				get { return new Sys_NoticeRepository(this); }
			}
		        public IDAL.Isys_organizeRepository sys_organizeRepository
			{
				get { return new sys_organizeRepository(this); }
			}
		        public IDAL.Isys_organize_bakRepository sys_organize_bakRepository
			{
				get { return new sys_organize_bakRepository(this); }
			}
		        public IDAL.Isys_OrganizeMakePriceMethodRepository sys_OrganizeMakePriceMethodRepository
			{
				get { return new sys_OrganizeMakePriceMethodRepository(this); }
			}
		        public IDAL.Isys_ParameterRepository sys_ParameterRepository
			{
				get { return new sys_ParameterRepository(this); }
			}
		        public IDAL.Isys_ParameterConditionRepository sys_ParameterConditionRepository
			{
				get { return new sys_ParameterConditionRepository(this); }
			}
		        public IDAL.Isys_ParameterConditionValueRepository sys_ParameterConditionValueRepository
			{
				get { return new sys_ParameterConditionValueRepository(this); }
			}
		        public IDAL.Isys_ParameterScoreRepository sys_ParameterScoreRepository
			{
				get { return new sys_ParameterScoreRepository(this); }
			}
		        public IDAL.Isys_ParameterScoreValueRepository sys_ParameterScoreValueRepository
			{
				get { return new sys_ParameterScoreValueRepository(this); }
			}
		        public IDAL.Isys_ParameterSettingRepository sys_ParameterSettingRepository
			{
				get { return new sys_ParameterSettingRepository(this); }
			}
		        public IDAL.Isys_ParameterValueRepository sys_ParameterValueRepository
			{
				get { return new sys_ParameterValueRepository(this); }
			}
		        public IDAL.Isys_plateInfoRepository sys_plateInfoRepository
			{
				get { return new sys_plateInfoRepository(this); }
			}
		        public IDAL.Isys_PriceProportionRepository sys_PriceProportionRepository
			{
				get { return new sys_PriceProportionRepository(this); }
			}
		        public IDAL.Isys_ProductRepository sys_ProductRepository
			{
				get { return new sys_ProductRepository(this); }
			}
		        public IDAL.Isys_ProductAuthorizationRepository sys_ProductAuthorizationRepository
			{
				get { return new sys_ProductAuthorizationRepository(this); }
			}
		        public IDAL.Isys_propertyPlateCollectsRepository sys_propertyPlateCollectsRepository
			{
				get { return new sys_propertyPlateCollectsRepository(this); }
			}
		        public IDAL.Isys_propertyTypeConditionRepository sys_propertyTypeConditionRepository
			{
				get { return new sys_propertyTypeConditionRepository(this); }
			}
		        public IDAL.Isys_propertyTypeValueRepository sys_propertyTypeValueRepository
			{
				get { return new sys_propertyTypeValueRepository(this); }
			}
		        public IDAL.Isys_propertyTypeValueOrganizationRepository sys_propertyTypeValueOrganizationRepository
			{
				get { return new sys_propertyTypeValueOrganizationRepository(this); }
			}
		        public IDAL.Isys_roleRepository sys_roleRepository
			{
				get { return new sys_roleRepository(this); }
			}
		        public IDAL.Isys_roleMenuRepository sys_roleMenuRepository
			{
				get { return new sys_roleMenuRepository(this); }
			}
		        public IDAL.Isys_roleUserRepository sys_roleUserRepository
			{
				get { return new sys_roleUserRepository(this); }
			}
		        public IDAL.Isys_TaxRepository sys_TaxRepository
			{
				get { return new sys_TaxRepository(this); }
			}
		        public IDAL.Isys_UsageLogRepository sys_UsageLogRepository
			{
				get { return new sys_UsageLogRepository(this); }
			}
		        public IDAL.Isys_userRepository sys_userRepository
			{
				get { return new sys_userRepository(this); }
			}
		        public IDAL.Isys_userTemplateRepository sys_userTemplateRepository
			{
				get { return new sys_userTemplateRepository(this); }
			}
		        public IDAL.IsysarticlecolumnsRepository sysarticlecolumnsRepository
			{
				get { return new sysarticlecolumnsRepository(this); }
			}
		        public IDAL.IsysarticlesRepository sysarticlesRepository
			{
				get { return new sysarticlesRepository(this); }
			}
		        public IDAL.IsysarticleupdatesRepository sysarticleupdatesRepository
			{
				get { return new sysarticleupdatesRepository(this); }
			}
		        public IDAL.IsysdiagramsRepository sysdiagramsRepository
			{
				get { return new sysdiagramsRepository(this); }
			}
		        public IDAL.IsyspublicationsRepository syspublicationsRepository
			{
				get { return new syspublicationsRepository(this); }
			}
		        public IDAL.IsysreplserversRepository sysreplserversRepository
			{
				get { return new sysreplserversRepository(this); }
			}
		        public IDAL.IsysschemaarticlesRepository sysschemaarticlesRepository
			{
				get { return new sysschemaarticlesRepository(this); }
			}
		        public IDAL.IsyssubscriptionsRepository syssubscriptionsRepository
			{
				get { return new syssubscriptionsRepository(this); }
			}
		        public IDAL.IsystranschemasRepository systranschemasRepository
			{
				get { return new systranschemasRepository(this); }
			}
		}
}