  //引进TT模板的命名空间

//使用TT模板生成代码的片段
using Service.IDAL;
using Service.Model;
using System.Data.Entity;

namespace Service.DAL
{


	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。


	

	    public partial class Cus_AppraisalInstitutionRepository : BaseRepository<Cus_AppraisalInstitution>, ICus_AppraisalInstitutionRepository
		{
			 public Cus_AppraisalInstitutionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_AreaDistributionRepository : BaseRepository<Cus_AreaDistribution>, ICus_AreaDistributionRepository
		{
			 public Cus_AreaDistributionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_BranchRepository : BaseRepository<Cus_Branch>, ICus_BranchRepository
		{
			 public Cus_BranchRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_CompanyRepository : BaseRepository<Cus_Company>, ICus_CompanyRepository
		{
			 public Cus_CompanyRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_ConfigRepository : BaseRepository<Cus_Config>, ICus_ConfigRepository
		{
			 public Cus_ConfigRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_IsQueryRepository : BaseRepository<Cus_IsQuery>, ICus_IsQueryRepository
		{
			 public Cus_IsQueryRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_OrganizationRepository : BaseRepository<Cus_Organization>, ICus_OrganizationRepository
		{
			 public Cus_OrganizationRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_PostRepository : BaseRepository<Cus_Post>, ICus_PostRepository
		{
			 public Cus_PostRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_PriceResultConfigRepository : BaseRepository<Cus_PriceResultConfig>, ICus_PriceResultConfigRepository
		{
			 public Cus_PriceResultConfigRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_ProductDistributionRepository : BaseRepository<Cus_ProductDistribution>, ICus_ProductDistributionRepository
		{
			 public Cus_ProductDistributionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_PropertyDistributionRepository : BaseRepository<Cus_PropertyDistribution>, ICus_PropertyDistributionRepository
		{
			 public Cus_PropertyDistributionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_RoleRepository : BaseRepository<Cus_Role>, ICus_RoleRepository
		{
			 public Cus_RoleRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_RoleMenuRepository : BaseRepository<Cus_RoleMenu>, ICus_RoleMenuRepository
		{
			 public Cus_RoleMenuRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_RoleUserRepository : BaseRepository<Cus_RoleUser>, ICus_RoleUserRepository
		{
			 public Cus_RoleUserRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_ServiceAreaRepository : BaseRepository<Cus_ServiceArea>, ICus_ServiceAreaRepository
		{
			 public Cus_ServiceAreaRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_TempletDistributionRepository : BaseRepository<Cus_TempletDistribution>, ICus_TempletDistributionRepository
		{
			 public Cus_TempletDistributionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Cus_UserRepository : BaseRepository<Cus_User>, ICus_UserRepository
		{
			 public Cus_UserRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_attachmentRepository : BaseRepository<data_attachment>, Idata_attachmentRepository
		{
			 public data_attachmentRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_baseInfoAllFieldsRepository : BaseRepository<data_baseInfoAllFields>, Idata_baseInfoAllFieldsRepository
		{
			 public data_baseInfoAllFieldsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_baseInfoGroupRepository : BaseRepository<data_baseInfoGroup>, Idata_baseInfoGroupRepository
		{
			 public data_baseInfoGroupRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_baseInfoGroupFieldsRepository : BaseRepository<data_baseInfoGroupFields>, Idata_baseInfoGroupFieldsRepository
		{
			 public data_baseInfoGroupFieldsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_BuildingTargetRepository : BaseRepository<data_BuildingTarget>, Idata_BuildingTargetRepository
		{
			 public data_BuildingTargetRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_HousingCaseRepository : BaseRepository<data_HousingCase>, Idata_HousingCaseRepository
		{
			 public data_HousingCaseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_HousingLeaseCaseRepository : BaseRepository<data_HousingLeaseCase>, Idata_HousingLeaseCaseRepository
		{
			 public data_HousingLeaseCaseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_makePriceListRepository : BaseRepository<data_makePriceList>, Idata_makePriceListRepository
		{
			 public data_makePriceListRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_makePriceListDetailRepository : BaseRepository<data_makePriceListDetail>, Idata_makePriceListDetailRepository
		{
			 public data_makePriceListDetailRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_makePriceListMethodRepository : BaseRepository<data_makePriceListMethod>, Idata_makePriceListMethodRepository
		{
			 public data_makePriceListMethodRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_makePriceListObjectRepository : BaseRepository<data_makePriceListObject>, Idata_makePriceListObjectRepository
		{
			 public data_makePriceListObjectRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_makePriceListObjectTempRepository : BaseRepository<data_makePriceListObjectTemp>, Idata_makePriceListObjectTempRepository
		{
			 public data_makePriceListObjectTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_makePriceListProcessRepository : BaseRepository<data_makePriceListProcess>, Idata_makePriceListProcessRepository
		{
			 public data_makePriceListProcessRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_makePriceListResultRepository : BaseRepository<data_makePriceListResult>, Idata_makePriceListResultRepository
		{
			 public data_makePriceListResultRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_MakePriceSubmitLogRepository : BaseRepository<data_MakePriceSubmitLog>, Idata_MakePriceSubmitLogRepository
		{
			 public data_MakePriceSubmitLogRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_NewsBulletinInfoRepository : BaseRepository<data_NewsBulletinInfo>, Idata_NewsBulletinInfoRepository
		{
			 public data_NewsBulletinInfoRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_OfficeBuildingsCaseRepository : BaseRepository<data_OfficeBuildingsCase>, Idata_OfficeBuildingsCaseRepository
		{
			 public data_OfficeBuildingsCaseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_OfficeBuildingsLeaseCaseRepository : BaseRepository<data_OfficeBuildingsLeaseCase>, Idata_OfficeBuildingsLeaseCaseRepository
		{
			 public data_OfficeBuildingsLeaseCaseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeFloorRepository : BaseRepository<data_officeFloor>, Idata_officeFloorRepository
		{
			 public data_officeFloorRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeFloorPriceRepository : BaseRepository<data_officeFloorPrice>, Idata_officeFloorPriceRepository
		{
			 public data_officeFloorPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeFloorPriceTempRepository : BaseRepository<data_officeFloorPriceTemp>, Idata_officeFloorPriceTempRepository
		{
			 public data_officeFloorPriceTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeFloorTempRepository : BaseRepository<data_officeFloorTemp>, Idata_officeFloorTempRepository
		{
			 public data_officeFloorTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeFloorUpdateSolrRepository : BaseRepository<data_officeFloorUpdateSolr>, Idata_officeFloorUpdateSolrRepository
		{
			 public data_officeFloorUpdateSolrRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeProjectRepository : BaseRepository<data_officeProject>, Idata_officeProjectRepository
		{
			 public data_officeProjectRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeProjectPriceRepository : BaseRepository<data_officeProjectPrice>, Idata_officeProjectPriceRepository
		{
			 public data_officeProjectPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeProjectPriceTempRepository : BaseRepository<data_officeProjectPriceTemp>, Idata_officeProjectPriceTempRepository
		{
			 public data_officeProjectPriceTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeProjectPropertyTypeRepository : BaseRepository<data_officeProjectPropertyType>, Idata_officeProjectPropertyTypeRepository
		{
			 public data_officeProjectPropertyTypeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeProjectSummaryPriceRepository : BaseRepository<data_officeProjectSummaryPrice>, Idata_officeProjectSummaryPriceRepository
		{
			 public data_officeProjectSummaryPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeProjectTempRepository : BaseRepository<data_officeProjectTemp>, Idata_officeProjectTempRepository
		{
			 public data_officeProjectTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeProjectUpdateSolrRepository : BaseRepository<data_officeProjectUpdateSolr>, Idata_officeProjectUpdateSolrRepository
		{
			 public data_officeProjectUpdateSolrRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeRoomRepository : BaseRepository<data_officeRoom>, Idata_officeRoomRepository
		{
			 public data_officeRoomRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeRoomPriceRepository : BaseRepository<data_officeRoomPrice>, Idata_officeRoomPriceRepository
		{
			 public data_officeRoomPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeRoomPriceTempRepository : BaseRepository<data_officeRoomPriceTemp>, Idata_officeRoomPriceTempRepository
		{
			 public data_officeRoomPriceTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeRoomTempRepository : BaseRepository<data_officeRoomTemp>, Idata_officeRoomTempRepository
		{
			 public data_officeRoomTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_officeRoomUpdateSolrRepository : BaseRepository<data_officeRoomUpdateSolr>, Idata_officeRoomUpdateSolrRepository
		{
			 public data_officeRoomUpdateSolrRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_opinionLibraryRepository : BaseRepository<data_opinionLibrary>, Idata_opinionLibraryRepository
		{
			 public data_opinionLibraryRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_pictureTypeRepository : BaseRepository<data_pictureType>, Idata_pictureTypeRepository
		{
			 public data_pictureTypeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentFloorRepository : BaseRepository<data_residentFloor>, Idata_residentFloorRepository
		{
			 public data_residentFloorRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentFloorPriceRepository : BaseRepository<data_residentFloorPrice>, Idata_residentFloorPriceRepository
		{
			 public data_residentFloorPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentFloorPriceTempRepository : BaseRepository<data_residentFloorPriceTemp>, Idata_residentFloorPriceTempRepository
		{
			 public data_residentFloorPriceTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentFloorSettingRepository : BaseRepository<data_residentFloorSetting>, Idata_residentFloorSettingRepository
		{
			 public data_residentFloorSettingRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentFloorTempRepository : BaseRepository<data_residentFloorTemp>, Idata_residentFloorTempRepository
		{
			 public data_residentFloorTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentFloorUpdateSolrRepository : BaseRepository<data_residentFloorUpdateSolr>, Idata_residentFloorUpdateSolrRepository
		{
			 public data_residentFloorUpdateSolrRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectRepository : BaseRepository<data_residentProject>, Idata_residentProjectRepository
		{
			 public data_residentProjectRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectCashabilityRepository : BaseRepository<data_residentProjectCashability>, Idata_residentProjectCashabilityRepository
		{
			 public data_residentProjectCashabilityRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectPriceRepository : BaseRepository<data_residentProjectPrice>, Idata_residentProjectPriceRepository
		{
			 public data_residentProjectPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectPriceTempRepository : BaseRepository<data_residentProjectPriceTemp>, Idata_residentProjectPriceTempRepository
		{
			 public data_residentProjectPriceTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectPropertyTypeRepository : BaseRepository<data_residentProjectPropertyType>, Idata_residentProjectPropertyTypeRepository
		{
			 public data_residentProjectPropertyTypeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectSummaryPriceRepository : BaseRepository<data_residentProjectSummaryPrice>, Idata_residentProjectSummaryPriceRepository
		{
			 public data_residentProjectSummaryPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectTempRepository : BaseRepository<data_residentProjectTemp>, Idata_residentProjectTempRepository
		{
			 public data_residentProjectTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentProjectUpdateSolrRepository : BaseRepository<data_residentProjectUpdateSolr>, Idata_residentProjectUpdateSolrRepository
		{
			 public data_residentProjectUpdateSolrRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentRoomRepository : BaseRepository<data_residentRoom>, Idata_residentRoomRepository
		{
			 public data_residentRoomRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentRoomPriceRepository : BaseRepository<data_residentRoomPrice>, Idata_residentRoomPriceRepository
		{
			 public data_residentRoomPriceRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentRoomPriceTempRepository : BaseRepository<data_residentRoomPriceTemp>, Idata_residentRoomPriceTempRepository
		{
			 public data_residentRoomPriceTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentRoomSettingRepository : BaseRepository<data_residentRoomSetting>, Idata_residentRoomSettingRepository
		{
			 public data_residentRoomSettingRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentRoomTempRepository : BaseRepository<data_residentRoomTemp>, Idata_residentRoomTempRepository
		{
			 public data_residentRoomTempRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentRoomUpdateSolrRepository : BaseRepository<data_residentRoomUpdateSolr>, Idata_residentRoomUpdateSolrRepository
		{
			 public data_residentRoomUpdateSolrRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_residentTradeCaseRepository : BaseRepository<data_residentTradeCase>, Idata_residentTradeCaseRepository
		{
			 public data_residentTradeCaseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class data_uploadDirectoryRepository : BaseRepository<data_uploadDirectory>, Idata_uploadDirectoryRepository
		{
			 public data_uploadDirectoryRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class EstateStatitsticsRepository : BaseRepository<EstateStatitstics>, IEstateStatitsticsRepository
		{
			 public EstateStatitsticsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class FloorFittedDataRepository : BaseRepository<FloorFittedData>, IFloorFittedDataRepository
		{
			 public FloorFittedDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class FloorPriceChangeRatioDataRepository : BaseRepository<FloorPriceChangeRatioData>, IFloorPriceChangeRatioDataRepository
		{
			 public FloorPriceChangeRatioDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class FloorSmoothDataRepository : BaseRepository<FloorSmoothData>, IFloorSmoothDataRepository
		{
			 public FloorSmoothDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_conflictdetectionconfigrequestRepository : BaseRepository<MSpeer_conflictdetectionconfigrequest>, IMSpeer_conflictdetectionconfigrequestRepository
		{
			 public MSpeer_conflictdetectionconfigrequestRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_conflictdetectionconfigresponseRepository : BaseRepository<MSpeer_conflictdetectionconfigresponse>, IMSpeer_conflictdetectionconfigresponseRepository
		{
			 public MSpeer_conflictdetectionconfigresponseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_lsnsRepository : BaseRepository<MSpeer_lsns>, IMSpeer_lsnsRepository
		{
			 public MSpeer_lsnsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_originatorid_historyRepository : BaseRepository<MSpeer_originatorid_history>, IMSpeer_originatorid_historyRepository
		{
			 public MSpeer_originatorid_historyRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_requestRepository : BaseRepository<MSpeer_request>, IMSpeer_requestRepository
		{
			 public MSpeer_requestRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_responseRepository : BaseRepository<MSpeer_response>, IMSpeer_responseRepository
		{
			 public MSpeer_responseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_topologyrequestRepository : BaseRepository<MSpeer_topologyrequest>, IMSpeer_topologyrequestRepository
		{
			 public MSpeer_topologyrequestRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpeer_topologyresponseRepository : BaseRepository<MSpeer_topologyresponse>, IMSpeer_topologyresponseRepository
		{
			 public MSpeer_topologyresponseRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class MSpub_identity_rangeRepository : BaseRepository<MSpub_identity_range>, IMSpub_identity_rangeRepository
		{
			 public MSpub_identity_rangeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class ProjectFittedDataRepository : BaseRepository<ProjectFittedData>, IProjectFittedDataRepository
		{
			 public ProjectFittedDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class ProjectPriceChangeRatioDataRepository : BaseRepository<ProjectPriceChangeRatioData>, IProjectPriceChangeRatioDataRepository
		{
			 public ProjectPriceChangeRatioDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class ProjectSmoothDataRepository : BaseRepository<ProjectSmoothData>, IProjectSmoothDataRepository
		{
			 public ProjectSmoothDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class RoomFittedDataRepository : BaseRepository<RoomFittedData>, IRoomFittedDataRepository
		{
			 public RoomFittedDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class RoomPriceChangeRatioDataRepository : BaseRepository<RoomPriceChangeRatioData>, IRoomPriceChangeRatioDataRepository
		{
			 public RoomPriceChangeRatioDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class RoomSmoothDataRepository : BaseRepository<RoomSmoothData>, IRoomSmoothDataRepository
		{
			 public RoomSmoothDataRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_applicationRepository : BaseRepository<sys_application>, Isys_applicationRepository
		{
			 public sys_applicationRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Sys_AreaRepository : BaseRepository<Sys_Area>, ISys_AreaRepository
		{
			 public Sys_AreaRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_CAADMethodRepository : BaseRepository<sys_CAADMethod>, Isys_CAADMethodRepository
		{
			 public sys_CAADMethodRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_CAADMethodPropertyRepository : BaseRepository<sys_CAADMethodProperty>, Isys_CAADMethodPropertyRepository
		{
			 public sys_CAADMethodPropertyRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_CusOrgRelationRepository : BaseRepository<sys_CusOrgRelation>, Isys_CusOrgRelationRepository
		{
			 public sys_CusOrgRelationRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_dictRepository : BaseRepository<sys_dict>, Isys_dictRepository
		{
			 public sys_dictRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_dictOrganizeRepository : BaseRepository<sys_dictOrganize>, Isys_dictOrganizeRepository
		{
			 public sys_dictOrganizeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_dictTypeRepository : BaseRepository<sys_dictType>, Isys_dictTypeRepository
		{
			 public sys_dictTypeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_employeeRepository : BaseRepository<sys_employee>, Isys_employeeRepository
		{
			 public sys_employeeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_fucGroupRepository : BaseRepository<sys_fucGroup>, Isys_fucGroupRepository
		{
			 public sys_fucGroupRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_functionRepository : BaseRepository<sys_function>, Isys_functionRepository
		{
			 public sys_functionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_generateRuleRepository : BaseRepository<sys_generateRule>, Isys_generateRuleRepository
		{
			 public sys_generateRuleRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_gisRepository : BaseRepository<sys_gis>, Isys_gisRepository
		{
			 public sys_gisRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Sys_GlossaryRepository : BaseRepository<Sys_Glossary>, ISys_GlossaryRepository
		{
			 public Sys_GlossaryRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_HelpContentRepository : BaseRepository<sys_HelpContent>, Isys_HelpContentRepository
		{
			 public sys_HelpContentRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_HelpGroupRepository : BaseRepository<sys_HelpGroup>, Isys_HelpGroupRepository
		{
			 public sys_HelpGroupRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_IsQueryRepository : BaseRepository<sys_IsQuery>, Isys_IsQueryRepository
		{
			 public sys_IsQueryRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_jobsRepository : BaseRepository<sys_jobs>, Isys_jobsRepository
		{
			 public sys_jobsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_MakePriceMethodRepository : BaseRepository<sys_MakePriceMethod>, Isys_MakePriceMethodRepository
		{
			 public sys_MakePriceMethodRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_MakePriceQueryRepository : BaseRepository<sys_MakePriceQuery>, Isys_MakePriceQueryRepository
		{
			 public sys_MakePriceQueryRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_MakePriceTemplateRepository : BaseRepository<sys_MakePriceTemplate>, Isys_MakePriceTemplateRepository
		{
			 public sys_MakePriceTemplateRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_menuRepository : BaseRepository<sys_menu>, Isys_menuRepository
		{
			 public sys_menuRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_MethodTitleRepository : BaseRepository<sys_MethodTitle>, Isys_MethodTitleRepository
		{
			 public sys_MethodTitleRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class Sys_NoticeRepository : BaseRepository<Sys_Notice>, ISys_NoticeRepository
		{
			 public Sys_NoticeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_organizeRepository : BaseRepository<sys_organize>, Isys_organizeRepository
		{
			 public sys_organizeRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_organize_bakRepository : BaseRepository<sys_organize_bak>, Isys_organize_bakRepository
		{
			 public sys_organize_bakRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_OrganizeMakePriceMethodRepository : BaseRepository<sys_OrganizeMakePriceMethod>, Isys_OrganizeMakePriceMethodRepository
		{
			 public sys_OrganizeMakePriceMethodRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ParameterRepository : BaseRepository<sys_Parameter>, Isys_ParameterRepository
		{
			 public sys_ParameterRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ParameterConditionRepository : BaseRepository<sys_ParameterCondition>, Isys_ParameterConditionRepository
		{
			 public sys_ParameterConditionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ParameterConditionValueRepository : BaseRepository<sys_ParameterConditionValue>, Isys_ParameterConditionValueRepository
		{
			 public sys_ParameterConditionValueRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ParameterScoreRepository : BaseRepository<sys_ParameterScore>, Isys_ParameterScoreRepository
		{
			 public sys_ParameterScoreRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ParameterScoreValueRepository : BaseRepository<sys_ParameterScoreValue>, Isys_ParameterScoreValueRepository
		{
			 public sys_ParameterScoreValueRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ParameterSettingRepository : BaseRepository<sys_ParameterSetting>, Isys_ParameterSettingRepository
		{
			 public sys_ParameterSettingRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ParameterValueRepository : BaseRepository<sys_ParameterValue>, Isys_ParameterValueRepository
		{
			 public sys_ParameterValueRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_plateInfoRepository : BaseRepository<sys_plateInfo>, Isys_plateInfoRepository
		{
			 public sys_plateInfoRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_PriceProportionRepository : BaseRepository<sys_PriceProportion>, Isys_PriceProportionRepository
		{
			 public sys_PriceProportionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ProductRepository : BaseRepository<sys_Product>, Isys_ProductRepository
		{
			 public sys_ProductRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_ProductAuthorizationRepository : BaseRepository<sys_ProductAuthorization>, Isys_ProductAuthorizationRepository
		{
			 public sys_ProductAuthorizationRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_propertyPlateCollectsRepository : BaseRepository<sys_propertyPlateCollects>, Isys_propertyPlateCollectsRepository
		{
			 public sys_propertyPlateCollectsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_propertyTypeConditionRepository : BaseRepository<sys_propertyTypeCondition>, Isys_propertyTypeConditionRepository
		{
			 public sys_propertyTypeConditionRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_propertyTypeValueRepository : BaseRepository<sys_propertyTypeValue>, Isys_propertyTypeValueRepository
		{
			 public sys_propertyTypeValueRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_propertyTypeValueOrganizationRepository : BaseRepository<sys_propertyTypeValueOrganization>, Isys_propertyTypeValueOrganizationRepository
		{
			 public sys_propertyTypeValueOrganizationRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_roleRepository : BaseRepository<sys_role>, Isys_roleRepository
		{
			 public sys_roleRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_roleMenuRepository : BaseRepository<sys_roleMenu>, Isys_roleMenuRepository
		{
			 public sys_roleMenuRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_roleUserRepository : BaseRepository<sys_roleUser>, Isys_roleUserRepository
		{
			 public sys_roleUserRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_TaxRepository : BaseRepository<sys_Tax>, Isys_TaxRepository
		{
			 public sys_TaxRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_UsageLogRepository : BaseRepository<sys_UsageLog>, Isys_UsageLogRepository
		{
			 public sys_UsageLogRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_userRepository : BaseRepository<sys_user>, Isys_userRepository
		{
			 public sys_userRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sys_userTemplateRepository : BaseRepository<sys_userTemplate>, Isys_userTemplateRepository
		{
			 public sys_userTemplateRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sysarticlecolumnsRepository : BaseRepository<sysarticlecolumns>, IsysarticlecolumnsRepository
		{
			 public sysarticlecolumnsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sysarticlesRepository : BaseRepository<sysarticles>, IsysarticlesRepository
		{
			 public sysarticlesRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sysarticleupdatesRepository : BaseRepository<sysarticleupdates>, IsysarticleupdatesRepository
		{
			 public sysarticleupdatesRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sysdiagramsRepository : BaseRepository<sysdiagrams>, IsysdiagramsRepository
		{
			 public sysdiagramsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class syspublicationsRepository : BaseRepository<syspublications>, IsyspublicationsRepository
		{
			 public syspublicationsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sysreplserversRepository : BaseRepository<sysreplservers>, IsysreplserversRepository
		{
			 public sysreplserversRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class sysschemaarticlesRepository : BaseRepository<sysschemaarticles>, IsysschemaarticlesRepository
		{
			 public sysschemaarticlesRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class syssubscriptionsRepository : BaseRepository<syssubscriptions>, IsyssubscriptionsRepository
		{
			 public syssubscriptionsRepository(DbSession session) : base(session)
	        {
	        }
		}
	

	    public partial class systranschemasRepository : BaseRepository<systranschemas>, IsystranschemasRepository
		{
			 public systranschemasRepository(DbSession session) : base(session)
	        {
	        }
		}
	

}