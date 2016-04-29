  //引进TT模板的命名空间

//使用TT模板生成代码的片段
using System.Text;
using System.Threading.Tasks;
using Service.DAL;
using Service.IBLL;
using Service.IDAL;
using Service.Model;

namespace Service.BLL
{

	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。

	 public partial class Cus_AppraisalInstitutionService : BaseService<Cus_AppraisalInstitution>, ICus_AppraisalInstitutionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_AppraisalInstitutionRepository;
        }
	}
	 public partial class Cus_AreaDistributionService : BaseService<Cus_AreaDistribution>, ICus_AreaDistributionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_AreaDistributionRepository;
        }
	}
	 public partial class Cus_ConfigService : BaseService<Cus_Config>, ICus_ConfigService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_ConfigRepository;
        }
	}
	 public partial class Cus_IsQueryService : BaseService<Cus_IsQuery>, ICus_IsQueryService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_IsQueryRepository;
        }
	}
	 public partial class Cus_OrganizationService : BaseService<Cus_Organization>, ICus_OrganizationService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_OrganizationRepository;
        }
	}
	 public partial class Cus_PostService : BaseService<Cus_Post>, ICus_PostService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_PostRepository;
        }
	}
	 public partial class Cus_PriceResultConfigService : BaseService<Cus_PriceResultConfig>, ICus_PriceResultConfigService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_PriceResultConfigRepository;
        }
	}
	 public partial class Cus_ProductDistributionService : BaseService<Cus_ProductDistribution>, ICus_ProductDistributionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_ProductDistributionRepository;
        }
	}
	 public partial class Cus_PropertyDistributionService : BaseService<Cus_PropertyDistribution>, ICus_PropertyDistributionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_PropertyDistributionRepository;
        }
	}
	 public partial class Cus_RoleService : BaseService<Cus_Role>, ICus_RoleService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_RoleRepository;
        }
	}
	 public partial class Cus_RoleMenuService : BaseService<Cus_RoleMenu>, ICus_RoleMenuService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_RoleMenuRepository;
        }
	}
	 public partial class Cus_RoleUserService : BaseService<Cus_RoleUser>, ICus_RoleUserService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_RoleUserRepository;
        }
	}
	 public partial class Cus_ServiceAreaService : BaseService<Cus_ServiceArea>, ICus_ServiceAreaService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_ServiceAreaRepository;
        }
	}
	 public partial class Cus_TempletDistributionService : BaseService<Cus_TempletDistribution>, ICus_TempletDistributionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_TempletDistributionRepository;
        }
	}
	 public partial class Cus_UserService : BaseService<Cus_User>, ICus_UserService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Cus_UserRepository;
        }
	}
	 public partial class data_attachmentService : BaseService<data_attachment>, Idata_attachmentService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_attachmentRepository;
        }
	}
	 public partial class data_baseInfoAllFieldsService : BaseService<data_baseInfoAllFields>, Idata_baseInfoAllFieldsService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_baseInfoAllFieldsRepository;
        }
	}
	 public partial class data_baseInfoGroupService : BaseService<data_baseInfoGroup>, Idata_baseInfoGroupService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_baseInfoGroupRepository;
        }
	}
	 public partial class data_baseInfoGroupFieldsService : BaseService<data_baseInfoGroupFields>, Idata_baseInfoGroupFieldsService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_baseInfoGroupFieldsRepository;
        }
	}
	 public partial class data_BuildingTargetService : BaseService<data_BuildingTarget>, Idata_BuildingTargetService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_BuildingTargetRepository;
        }
	}
	 public partial class data_HousingCaseService : BaseService<data_HousingCase>, Idata_HousingCaseService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_HousingCaseRepository;
        }
	}
	 public partial class data_HousingLeaseCaseService : BaseService<data_HousingLeaseCase>, Idata_HousingLeaseCaseService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_HousingLeaseCaseRepository;
        }
	}
	 public partial class data_makePriceListService : BaseService<data_makePriceList>, Idata_makePriceListService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_makePriceListRepository;
        }
	}
	 public partial class data_makePriceListDetailService : BaseService<data_makePriceListDetail>, Idata_makePriceListDetailService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_makePriceListDetailRepository;
        }
	}
	 public partial class data_makePriceListMethodService : BaseService<data_makePriceListMethod>, Idata_makePriceListMethodService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_makePriceListMethodRepository;
        }
	}
	 public partial class data_makePriceListObjectService : BaseService<data_makePriceListObject>, Idata_makePriceListObjectService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_makePriceListObjectRepository;
        }
	}
	 public partial class data_makePriceListObjectTempService : BaseService<data_makePriceListObjectTemp>, Idata_makePriceListObjectTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_makePriceListObjectTempRepository;
        }
	}
	 public partial class data_makePriceListProcessService : BaseService<data_makePriceListProcess>, Idata_makePriceListProcessService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_makePriceListProcessRepository;
        }
	}
	 public partial class data_makePriceListResultService : BaseService<data_makePriceListResult>, Idata_makePriceListResultService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_makePriceListResultRepository;
        }
	}
	 public partial class data_MakePriceSubmitLogService : BaseService<data_MakePriceSubmitLog>, Idata_MakePriceSubmitLogService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_MakePriceSubmitLogRepository;
        }
	}
	 public partial class data_NewsBulletinInfoService : BaseService<data_NewsBulletinInfo>, Idata_NewsBulletinInfoService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_NewsBulletinInfoRepository;
        }
	}
	 public partial class data_OfficeBuildingsCaseService : BaseService<data_OfficeBuildingsCase>, Idata_OfficeBuildingsCaseService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_OfficeBuildingsCaseRepository;
        }
	}
	 public partial class data_OfficeBuildingsLeaseCaseService : BaseService<data_OfficeBuildingsLeaseCase>, Idata_OfficeBuildingsLeaseCaseService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_OfficeBuildingsLeaseCaseRepository;
        }
	}
	 public partial class data_officeFloorService : BaseService<data_officeFloor>, Idata_officeFloorService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeFloorRepository;
        }
	}
	 public partial class data_officeFloorPriceService : BaseService<data_officeFloorPrice>, Idata_officeFloorPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeFloorPriceRepository;
        }
	}
	 public partial class data_officeFloorPriceTempService : BaseService<data_officeFloorPriceTemp>, Idata_officeFloorPriceTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeFloorPriceTempRepository;
        }
	}
	 public partial class data_officeFloorTempService : BaseService<data_officeFloorTemp>, Idata_officeFloorTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeFloorTempRepository;
        }
	}
	 public partial class data_officeFloorUpdateSolrService : BaseService<data_officeFloorUpdateSolr>, Idata_officeFloorUpdateSolrService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeFloorUpdateSolrRepository;
        }
	}
	 public partial class data_officeProjectService : BaseService<data_officeProject>, Idata_officeProjectService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeProjectRepository;
        }
	}
	 public partial class data_officeProjectPriceService : BaseService<data_officeProjectPrice>, Idata_officeProjectPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeProjectPriceRepository;
        }
	}
	 public partial class data_officeProjectPriceTempService : BaseService<data_officeProjectPriceTemp>, Idata_officeProjectPriceTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeProjectPriceTempRepository;
        }
	}
	 public partial class data_officeProjectPropertyTypeService : BaseService<data_officeProjectPropertyType>, Idata_officeProjectPropertyTypeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeProjectPropertyTypeRepository;
        }
	}
	 public partial class data_officeProjectSummaryPriceService : BaseService<data_officeProjectSummaryPrice>, Idata_officeProjectSummaryPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeProjectSummaryPriceRepository;
        }
	}
	 public partial class data_officeProjectTempService : BaseService<data_officeProjectTemp>, Idata_officeProjectTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeProjectTempRepository;
        }
	}
	 public partial class data_officeProjectUpdateSolrService : BaseService<data_officeProjectUpdateSolr>, Idata_officeProjectUpdateSolrService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeProjectUpdateSolrRepository;
        }
	}
	 public partial class data_officeRoomService : BaseService<data_officeRoom>, Idata_officeRoomService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeRoomRepository;
        }
	}
	 public partial class data_officeRoomPriceService : BaseService<data_officeRoomPrice>, Idata_officeRoomPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeRoomPriceRepository;
        }
	}
	 public partial class data_officeRoomPriceTempService : BaseService<data_officeRoomPriceTemp>, Idata_officeRoomPriceTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeRoomPriceTempRepository;
        }
	}
	 public partial class data_officeRoomTempService : BaseService<data_officeRoomTemp>, Idata_officeRoomTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeRoomTempRepository;
        }
	}
	 public partial class data_officeRoomUpdateSolrService : BaseService<data_officeRoomUpdateSolr>, Idata_officeRoomUpdateSolrService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_officeRoomUpdateSolrRepository;
        }
	}
	 public partial class data_opinionLibraryService : BaseService<data_opinionLibrary>, Idata_opinionLibraryService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_opinionLibraryRepository;
        }
	}
	 public partial class data_pictureTypeService : BaseService<data_pictureType>, Idata_pictureTypeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_pictureTypeRepository;
        }
	}
	 public partial class data_residentFloorService : BaseService<data_residentFloor>, Idata_residentFloorService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentFloorRepository;
        }
	}
	 public partial class data_residentFloorPriceService : BaseService<data_residentFloorPrice>, Idata_residentFloorPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentFloorPriceRepository;
        }
	}
	 public partial class data_residentFloorPriceTempService : BaseService<data_residentFloorPriceTemp>, Idata_residentFloorPriceTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentFloorPriceTempRepository;
        }
	}
	 public partial class data_residentFloorSettingService : BaseService<data_residentFloorSetting>, Idata_residentFloorSettingService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentFloorSettingRepository;
        }
	}
	 public partial class data_residentFloorTempService : BaseService<data_residentFloorTemp>, Idata_residentFloorTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentFloorTempRepository;
        }
	}
	 public partial class data_residentFloorUpdateSolrService : BaseService<data_residentFloorUpdateSolr>, Idata_residentFloorUpdateSolrService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentFloorUpdateSolrRepository;
        }
	}
	 public partial class data_residentProjectService : BaseService<data_residentProject>, Idata_residentProjectService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectRepository;
        }
	}
	 public partial class data_residentProjectCashabilityService : BaseService<data_residentProjectCashability>, Idata_residentProjectCashabilityService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectCashabilityRepository;
        }
	}
	 public partial class data_residentProjectPriceService : BaseService<data_residentProjectPrice>, Idata_residentProjectPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectPriceRepository;
        }
	}
	 public partial class data_residentProjectPriceTempService : BaseService<data_residentProjectPriceTemp>, Idata_residentProjectPriceTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectPriceTempRepository;
        }
	}
	 public partial class data_residentProjectPropertyTypeService : BaseService<data_residentProjectPropertyType>, Idata_residentProjectPropertyTypeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectPropertyTypeRepository;
        }
	}
	 public partial class data_residentProjectSummaryPriceService : BaseService<data_residentProjectSummaryPrice>, Idata_residentProjectSummaryPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectSummaryPriceRepository;
        }
	}
	 public partial class data_residentProjectTempService : BaseService<data_residentProjectTemp>, Idata_residentProjectTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectTempRepository;
        }
	}
	 public partial class data_residentProjectUpdateSolrService : BaseService<data_residentProjectUpdateSolr>, Idata_residentProjectUpdateSolrService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentProjectUpdateSolrRepository;
        }
	}
	 public partial class data_residentRoomService : BaseService<data_residentRoom>, Idata_residentRoomService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentRoomRepository;
        }
	}
	 public partial class data_residentRoomPriceService : BaseService<data_residentRoomPrice>, Idata_residentRoomPriceService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentRoomPriceRepository;
        }
	}
	 public partial class data_residentRoomPriceTempService : BaseService<data_residentRoomPriceTemp>, Idata_residentRoomPriceTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentRoomPriceTempRepository;
        }
	}
	 public partial class data_residentRoomSettingService : BaseService<data_residentRoomSetting>, Idata_residentRoomSettingService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentRoomSettingRepository;
        }
	}
	 public partial class data_residentRoomTempService : BaseService<data_residentRoomTemp>, Idata_residentRoomTempService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentRoomTempRepository;
        }
	}
	 public partial class data_residentRoomUpdateSolrService : BaseService<data_residentRoomUpdateSolr>, Idata_residentRoomUpdateSolrService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentRoomUpdateSolrRepository;
        }
	}
	 public partial class data_residentTradeCaseService : BaseService<data_residentTradeCase>, Idata_residentTradeCaseService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_residentTradeCaseRepository;
        }
	}
	 public partial class data_uploadDirectoryService : BaseService<data_uploadDirectory>, Idata_uploadDirectoryService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.data_uploadDirectoryRepository;
        }
	}
	 public partial class EstateStatitsticsService : BaseService<EstateStatitstics>, IEstateStatitsticsService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.EstateStatitsticsRepository;
        }
	}
	 public partial class FloorFittedDataService : BaseService<FloorFittedData>, IFloorFittedDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.FloorFittedDataRepository;
        }
	}
	 public partial class FloorPriceChangeRatioDataService : BaseService<FloorPriceChangeRatioData>, IFloorPriceChangeRatioDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.FloorPriceChangeRatioDataRepository;
        }
	}
	 public partial class FloorSmoothDataService : BaseService<FloorSmoothData>, IFloorSmoothDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.FloorSmoothDataRepository;
        }
	}


	 public partial class ProjectFittedDataService : BaseService<ProjectFittedData>, IProjectFittedDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.ProjectFittedDataRepository;
        }
	}
	 public partial class ProjectPriceChangeRatioDataService : BaseService<ProjectPriceChangeRatioData>, IProjectPriceChangeRatioDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.ProjectPriceChangeRatioDataRepository;
        }
	}
	 public partial class ProjectSmoothDataService : BaseService<ProjectSmoothData>, IProjectSmoothDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.ProjectSmoothDataRepository;
        }
	}
	 public partial class RoomFittedDataService : BaseService<RoomFittedData>, IRoomFittedDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.RoomFittedDataRepository;
        }
	}
	 public partial class RoomPriceChangeRatioDataService : BaseService<RoomPriceChangeRatioData>, IRoomPriceChangeRatioDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.RoomPriceChangeRatioDataRepository;
        }
	}
	 public partial class RoomSmoothDataService : BaseService<RoomSmoothData>, IRoomSmoothDataService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.RoomSmoothDataRepository;
        }
	}
	 public partial class sys_applicationService : BaseService<sys_application>, Isys_applicationService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_applicationRepository;
        }
	}

	 public partial class sys_CAADMethodService : BaseService<sys_CAADMethod>, Isys_CAADMethodService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_CAADMethodRepository;
        }
	}
	 public partial class sys_CAADMethodPropertyService : BaseService<sys_CAADMethodProperty>, Isys_CAADMethodPropertyService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_CAADMethodPropertyRepository;
        }
	}
	 public partial class sys_CusOrgRelationService : BaseService<sys_CusOrgRelation>, Isys_CusOrgRelationService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_CusOrgRelationRepository;
        }
	}
	 public partial class sys_dictService : BaseService<sys_dict>, Isys_dictService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_dictRepository;
        }
	}
	 public partial class sys_dictOrganizeService : BaseService<sys_dictOrganize>, Isys_dictOrganizeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_dictOrganizeRepository;
        }
	}
	 public partial class sys_dictTypeService : BaseService<sys_dictType>, Isys_dictTypeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_dictTypeRepository;
        }
	}
	 public partial class sys_employeeService : BaseService<sys_employee>, Isys_employeeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_employeeRepository;
        }
	}
	 public partial class sys_fucGroupService : BaseService<sys_fucGroup>, Isys_fucGroupService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_fucGroupRepository;
        }
	}
	 public partial class sys_functionService : BaseService<sys_function>, Isys_functionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_functionRepository;
        }
	}
	 public partial class sys_generateRuleService : BaseService<sys_generateRule>, Isys_generateRuleService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_generateRuleRepository;
        }
	}
	 public partial class sys_gisService : BaseService<sys_gis>, Isys_gisService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_gisRepository;
        }
	}

	 public partial class sys_HelpContentService : BaseService<sys_HelpContent>, Isys_HelpContentService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_HelpContentRepository;
        }
	}
	 public partial class sys_HelpGroupService : BaseService<sys_HelpGroup>, Isys_HelpGroupService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_HelpGroupRepository;
        }
	}
	 public partial class sys_IsQueryService : BaseService<sys_IsQuery>, Isys_IsQueryService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_IsQueryRepository;
        }
	}
	 public partial class sys_jobsService : BaseService<sys_jobs>, Isys_jobsService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_jobsRepository;
        }
	}
	 public partial class sys_MakePriceMethodService : BaseService<sys_MakePriceMethod>, Isys_MakePriceMethodService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_MakePriceMethodRepository;
        }
	}
	 public partial class sys_MakePriceQueryService : BaseService<sys_MakePriceQuery>, Isys_MakePriceQueryService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_MakePriceQueryRepository;
        }
	}
	 public partial class sys_MakePriceTemplateService : BaseService<sys_MakePriceTemplate>, Isys_MakePriceTemplateService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_MakePriceTemplateRepository;
        }
	}
	 public partial class sys_menuService : BaseService<sys_menu>, Isys_menuService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_menuRepository;
        }
	}
	 public partial class sys_MethodTitleService : BaseService<sys_MethodTitle>, Isys_MethodTitleService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_MethodTitleRepository;
        }
	}
	 public partial class Sys_NoticeService : BaseService<Sys_Notice>, ISys_NoticeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.Sys_NoticeRepository;
        }
	}
	 public partial class sys_organizeService : BaseService<sys_organize>, Isys_organizeService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_organizeRepository;
        }
	}

	 public partial class sys_OrganizeMakePriceMethodService : BaseService<sys_OrganizeMakePriceMethod>, Isys_OrganizeMakePriceMethodService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_OrganizeMakePriceMethodRepository;
        }
	}
	 public partial class sys_ParameterService : BaseService<sys_Parameter>, Isys_ParameterService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ParameterRepository;
        }
	}
	 public partial class sys_ParameterConditionService : BaseService<sys_ParameterCondition>, Isys_ParameterConditionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ParameterConditionRepository;
        }
	}
	 public partial class sys_ParameterConditionValueService : BaseService<sys_ParameterConditionValue>, Isys_ParameterConditionValueService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ParameterConditionValueRepository;
        }
	}
	 public partial class sys_ParameterScoreService : BaseService<sys_ParameterScore>, Isys_ParameterScoreService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ParameterScoreRepository;
        }
	}
	 public partial class sys_ParameterScoreValueService : BaseService<sys_ParameterScoreValue>, Isys_ParameterScoreValueService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ParameterScoreValueRepository;
        }
	}
	 public partial class sys_ParameterSettingService : BaseService<sys_ParameterSetting>, Isys_ParameterSettingService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ParameterSettingRepository;
        }
	}
	 public partial class sys_ParameterValueService : BaseService<sys_ParameterValue>, Isys_ParameterValueService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ParameterValueRepository;
        }
	}
	 public partial class sys_plateInfoService : BaseService<sys_plateInfo>, Isys_plateInfoService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_plateInfoRepository;
        }
	}
	 public partial class sys_PriceProportionService : BaseService<sys_PriceProportion>, Isys_PriceProportionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_PriceProportionRepository;
        }
	}
	 public partial class sys_ProductService : BaseService<sys_Product>, Isys_ProductService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ProductRepository;
        }
	}
	 public partial class sys_ProductAuthorizationService : BaseService<sys_ProductAuthorization>, Isys_ProductAuthorizationService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_ProductAuthorizationRepository;
        }
	}
	 public partial class sys_propertyPlateCollectsService : BaseService<sys_propertyPlateCollects>, Isys_propertyPlateCollectsService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_propertyPlateCollectsRepository;
        }
	}
	 public partial class sys_propertyTypeConditionService : BaseService<sys_propertyTypeCondition>, Isys_propertyTypeConditionService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_propertyTypeConditionRepository;
        }
	}
	 public partial class sys_propertyTypeValueService : BaseService<sys_propertyTypeValue>, Isys_propertyTypeValueService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_propertyTypeValueRepository;
        }
	}
	 public partial class sys_propertyTypeValueOrganizationService : BaseService<sys_propertyTypeValueOrganization>, Isys_propertyTypeValueOrganizationService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_propertyTypeValueOrganizationRepository;
        }
	}
	 public partial class sys_roleService : BaseService<sys_role>, Isys_roleService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_roleRepository;
        }
	}
	 public partial class sys_roleMenuService : BaseService<sys_roleMenu>, Isys_roleMenuService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_roleMenuRepository;
        }
	}
	 public partial class sys_roleUserService : BaseService<sys_roleUser>, Isys_roleUserService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_roleUserRepository;
        }
	}
	 public partial class sys_TaxService : BaseService<sys_Tax>, Isys_TaxService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_TaxRepository;
        }
	}
	 public partial class sys_UsageLogService : BaseService<sys_UsageLog>, Isys_UsageLogService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_UsageLogRepository;
        }
	}
	 public partial class sys_userService : BaseService<sys_user>, Isys_userService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_userRepository;
        }
	}
	 public partial class sys_userTemplateService : BaseService<sys_userTemplate>, Isys_userTemplateService
    {
		//只要想操作数据库，我们只要拿到DbSession就行
        public override void SetCurrentRepository()
        {
            CurrentRepository = _DbSession.sys_userTemplateRepository;
        }
	}
}