﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class LandSurveyDataSheet
    {
        public string Id { get; set; } // Primary Key
        public string UserId { get; set; }
        //
        public int AssetTypeId { get; set; }
        public LandAssetType AssetType { get; set; }
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
        //
        public string LandRightsOwner { get; set; }
        public int LandRightsStatusId { get; set; }
        public LandLandRightsStatus LandRightsStatus { get; set; }
        public string LandRightsHolding { get; set; }
        public string OtherRights { get; set; }
        //
        public string LandUses { get; set; }
        public double BuildingCoverageRatio { get; set; }
        public double FloorAreaRatio { get; set; }
        //
        public DateTime InspectionDate { get; set; }
        public DateTime ValueOpinionDate { get; set; }
        //
        public int AppraisalObjectId { get; set; }
        public LandAppraisalObject AppraisalObject { get; set; }
        public string AppraisalDescription { get; set; }
        //
        public int PriceTypeId { get; set; }
        public LandPriceType PriceType { get; set; }
        public int EvaluationRightsTypeId { get; set; }
        public LandEvaluationRightsType EvaluationRightsType { get; set; }
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
