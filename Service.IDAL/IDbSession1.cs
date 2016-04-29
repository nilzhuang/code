//引进TT模板的命名空间

//使用TT模板生成代码的片段
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IDAL
{
    public partial interface IDbSession
    {

        //在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。

        //每个表对应的实体仓储对象
        IDAL.ICus_AppraisalInstitutionRepository Cus_AppraisalInstitutionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_AreaDistributionRepository Cus_AreaDistributionRepository { get; }


        //每个表对应的实体仓储对象
        IDAL.ICus_ConfigRepository Cus_ConfigRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_IsQueryRepository Cus_IsQueryRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_OrganizationRepository Cus_OrganizationRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_PostRepository Cus_PostRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_PriceResultConfigRepository Cus_PriceResultConfigRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_ProductDistributionRepository Cus_ProductDistributionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_PropertyDistributionRepository Cus_PropertyDistributionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_RoleRepository Cus_RoleRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_RoleMenuRepository Cus_RoleMenuRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_RoleUserRepository Cus_RoleUserRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_ServiceAreaRepository Cus_ServiceAreaRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_TempletDistributionRepository Cus_TempletDistributionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ICus_UserRepository Cus_UserRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_attachmentRepository data_attachmentRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_baseInfoAllFieldsRepository data_baseInfoAllFieldsRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_baseInfoGroupRepository data_baseInfoGroupRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_baseInfoGroupFieldsRepository data_baseInfoGroupFieldsRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_BuildingTargetRepository data_BuildingTargetRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_HousingCaseRepository data_HousingCaseRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_HousingLeaseCaseRepository data_HousingLeaseCaseRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_makePriceListRepository data_makePriceListRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_makePriceListDetailRepository data_makePriceListDetailRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_makePriceListMethodRepository data_makePriceListMethodRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_makePriceListObjectRepository data_makePriceListObjectRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_makePriceListObjectTempRepository data_makePriceListObjectTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_makePriceListProcessRepository data_makePriceListProcessRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_makePriceListResultRepository data_makePriceListResultRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_MakePriceSubmitLogRepository data_MakePriceSubmitLogRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_NewsBulletinInfoRepository data_NewsBulletinInfoRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_OfficeBuildingsCaseRepository data_OfficeBuildingsCaseRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_OfficeBuildingsLeaseCaseRepository data_OfficeBuildingsLeaseCaseRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeFloorRepository data_officeFloorRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeFloorPriceRepository data_officeFloorPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeFloorPriceTempRepository data_officeFloorPriceTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeFloorTempRepository data_officeFloorTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeFloorUpdateSolrRepository data_officeFloorUpdateSolrRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeProjectRepository data_officeProjectRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeProjectPriceRepository data_officeProjectPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeProjectPriceTempRepository data_officeProjectPriceTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeProjectPropertyTypeRepository data_officeProjectPropertyTypeRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeProjectSummaryPriceRepository data_officeProjectSummaryPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeProjectTempRepository data_officeProjectTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeProjectUpdateSolrRepository data_officeProjectUpdateSolrRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeRoomRepository data_officeRoomRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeRoomPriceRepository data_officeRoomPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeRoomPriceTempRepository data_officeRoomPriceTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeRoomTempRepository data_officeRoomTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_officeRoomUpdateSolrRepository data_officeRoomUpdateSolrRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_opinionLibraryRepository data_opinionLibraryRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_pictureTypeRepository data_pictureTypeRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentFloorRepository data_residentFloorRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentFloorPriceRepository data_residentFloorPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentFloorPriceTempRepository data_residentFloorPriceTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentFloorSettingRepository data_residentFloorSettingRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentFloorTempRepository data_residentFloorTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentFloorUpdateSolrRepository data_residentFloorUpdateSolrRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectRepository data_residentProjectRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectCashabilityRepository data_residentProjectCashabilityRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectPriceRepository data_residentProjectPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectPriceTempRepository data_residentProjectPriceTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectPropertyTypeRepository data_residentProjectPropertyTypeRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectSummaryPriceRepository data_residentProjectSummaryPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectTempRepository data_residentProjectTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentProjectUpdateSolrRepository data_residentProjectUpdateSolrRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentRoomRepository data_residentRoomRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentRoomPriceRepository data_residentRoomPriceRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentRoomPriceTempRepository data_residentRoomPriceTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentRoomSettingRepository data_residentRoomSettingRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentRoomTempRepository data_residentRoomTempRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentRoomUpdateSolrRepository data_residentRoomUpdateSolrRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_residentTradeCaseRepository data_residentTradeCaseRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Idata_uploadDirectoryRepository data_uploadDirectoryRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IEstateStatitsticsRepository EstateStatitsticsRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IFloorFittedDataRepository FloorFittedDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IFloorPriceChangeRatioDataRepository FloorPriceChangeRatioDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IFloorSmoothDataRepository FloorSmoothDataRepository { get; }


        //每个表对应的实体仓储对象
        IDAL.IProjectFittedDataRepository ProjectFittedDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IProjectPriceChangeRatioDataRepository ProjectPriceChangeRatioDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IProjectSmoothDataRepository ProjectSmoothDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IRoomFittedDataRepository RoomFittedDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IRoomPriceChangeRatioDataRepository RoomPriceChangeRatioDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.IRoomSmoothDataRepository RoomSmoothDataRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_applicationRepository sys_applicationRepository { get; }


        //每个表对应的实体仓储对象
        IDAL.Isys_CAADMethodRepository sys_CAADMethodRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_CAADMethodPropertyRepository sys_CAADMethodPropertyRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_CusOrgRelationRepository sys_CusOrgRelationRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_dictRepository sys_dictRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_dictOrganizeRepository sys_dictOrganizeRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_dictTypeRepository sys_dictTypeRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_employeeRepository sys_employeeRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_fucGroupRepository sys_fucGroupRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_functionRepository sys_functionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_generateRuleRepository sys_generateRuleRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_gisRepository sys_gisRepository { get; }



        //每个表对应的实体仓储对象
        IDAL.Isys_HelpContentRepository sys_HelpContentRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_HelpGroupRepository sys_HelpGroupRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_IsQueryRepository sys_IsQueryRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_jobsRepository sys_jobsRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_MakePriceMethodRepository sys_MakePriceMethodRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_MakePriceQueryRepository sys_MakePriceQueryRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_MakePriceTemplateRepository sys_MakePriceTemplateRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_menuRepository sys_menuRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_MethodTitleRepository sys_MethodTitleRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.ISys_NoticeRepository Sys_NoticeRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_organizeRepository sys_organizeRepository { get; }

        //每个表对应的实体仓储对象

        //每个表对应的实体仓储对象
        IDAL.Isys_OrganizeMakePriceMethodRepository sys_OrganizeMakePriceMethodRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ParameterRepository sys_ParameterRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ParameterConditionRepository sys_ParameterConditionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ParameterConditionValueRepository sys_ParameterConditionValueRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ParameterScoreRepository sys_ParameterScoreRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ParameterScoreValueRepository sys_ParameterScoreValueRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ParameterSettingRepository sys_ParameterSettingRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ParameterValueRepository sys_ParameterValueRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_plateInfoRepository sys_plateInfoRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_PriceProportionRepository sys_PriceProportionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ProductRepository sys_ProductRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_ProductAuthorizationRepository sys_ProductAuthorizationRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_propertyPlateCollectsRepository sys_propertyPlateCollectsRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_propertyTypeConditionRepository sys_propertyTypeConditionRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_propertyTypeValueRepository sys_propertyTypeValueRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_propertyTypeValueOrganizationRepository sys_propertyTypeValueOrganizationRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_roleRepository sys_roleRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_roleMenuRepository sys_roleMenuRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_roleUserRepository sys_roleUserRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_TaxRepository sys_TaxRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_UsageLogRepository sys_UsageLogRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_userRepository sys_userRepository { get; }

        //每个表对应的实体仓储对象
        IDAL.Isys_userTemplateRepository sys_userTemplateRepository { get; }



    }
}