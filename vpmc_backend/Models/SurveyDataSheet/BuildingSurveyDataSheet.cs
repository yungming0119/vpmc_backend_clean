﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace vpmc_backend.Models
{
    public class BuildingSurveyDataSheet
    {
        public string Id { get; set; } // Primary Key
        public string UserId { get; set; }
        //
        public int AssetTypeId { get; set; }
        public BuildingAssetType AssetType { get; set; }
        //
        public string LandMarkCounty { get; set; }
        public string LandMarkVillage { get; set; }
        public string LandMarkName { get; set; }
        public string LandMarkCode { get; set; }
        //
        public string BuildMarkCounty { get; set; }
        public string BuildMarkVillage { get; set; }
        public string BuildMarkName { get; set; }
        public string BuildMarkCode { get; set; }
        //
        public string BuildAddressCounty { get; set; }
        public string BuildAddressVillage { get; set; }
        public string BuildAddress { get; set; }
        public double LandArea { get; set; }
        public double BuildingArea { get; set; }
        //
        public string LandRightsOwner { get; set; }
        public int LandRightsStatusId { get; set; }
        public BuildingLandRightsStatus LandRightsStatus { get; set; }
        public string LandRightsHolding { get; set; }
        public string BuildingRightsOwner { get; set; }
        public int BuildingRightsStatusId { get; set; }
        public BuildingBuildingRightsStatus BuildingRightsStatus { get; set; }
        public string BuildingRightsHolding { get; set; }
        public string OtherRights { get; set; }
        //
        public string LandUses { get; set; }
        public double BuildingCoverageRatio { get; set; }
        public double FloorAreaRatio { get; set; }
        public int BuildingUsageId { get; set; }
        public BuildingBuildingUsage BuildingUsage { get; set; }
        public int BuildingStructureId { get; set; }
        public BuildingBuildingStructure BuildingStructure { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BuildingFinishDate { get; set; }
        public int BuildingUpFloor { get; set; }
        public int BuildingDownFloor { get; set; }
        public int SurveyFloor { get; set; }
        //
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InspectionDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ValueOpinionDate { get; set; }
        //
        public int AppraisalObjectId {get;set;}
        public BuildingAppraisalObject AppraisalObject { get; set; }
        public string AppraisalDescription { get; set; }
        //
        public int PriceTypeId { get; set; }
        public BuildingPriceType PriceType { get; set; }
        public int EvaluationRightsTypeId { get; set; }
        public BuildingEvaluationRightsType EvaluationRightsType { get; set; }
        public string AppraisalCondition { get; set; }
        //
        public string SurveyorName { get; set; }
        public string SurveyDescription { get; set; }
        //
        // 以下為實體檔案預留位置
        //
        // 建物謄本檔案路徑
        // 現勘照片路徑
        public string TranscriptPath { get; set; }
        public string PhotoPath { get; set; }
    }
}
