﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vpmc_backend.Models;

namespace vpmc_backend.Migrations
{
    [DbContext(typeof(WebApiContext))]
    [Migration("20210722110104_remove")]
    partial class remove
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vpmc_backend.Models.BuildingAppraisalObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Object")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Building_AppraisalObject");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingAssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Building_AssetType");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingBuildingRightsStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Building_BuildingRightsStatus");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingBuildingStructure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Structure")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BuildingBuildingStructure");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingBuildingUsage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Usage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Building_BuildingUsage");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingEvaluationRightsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Building_EvaluationRightsType");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingLandRightsStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Building_LandRightsStatus");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingPriceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Building_PriceType");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingSurveyDataSheet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppraisalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppraisalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppraisalObjectId")
                        .HasColumnType("int");

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<string>("BuildAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildAddressCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildAddressVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BuildingArea")
                        .HasColumnType("float");

                    b.Property<double>("BuildingCoverageRatio")
                        .HasColumnType("float");

                    b.Property<int>("BuildingDownFloor")
                        .HasColumnType("int");

                    b.Property<DateTime>("BuildingFinishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BuildingRightsHolding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingRightsOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuildingRightsStatusId")
                        .HasColumnType("int");

                    b.Property<int>("BuildingStructureId")
                        .HasColumnType("int");

                    b.Property<int>("BuildingUpFloor")
                        .HasColumnType("int");

                    b.Property<int>("BuildingUsageId")
                        .HasColumnType("int");

                    b.Property<int>("EvaluationRightsTypeId")
                        .HasColumnType("int");

                    b.Property<double>("FloorAreaRatio")
                        .HasColumnType("float");

                    b.Property<DateTime>("InspectionDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("LandArea")
                        .HasColumnType("float");

                    b.Property<string>("LandMarkCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandRightsHolding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandRightsOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandRightsStatusId")
                        .HasColumnType("int");

                    b.Property<string>("LandUses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherRights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("SurveyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SurveyFloor")
                        .HasColumnType("int");

                    b.Property<string>("SurveyorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranscriptPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValueOpinionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppraisalObjectId");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("BuildingRightsStatusId");

                    b.HasIndex("BuildingStructureId");

                    b.HasIndex("BuildingUsageId");

                    b.HasIndex("EvaluationRightsTypeId");

                    b.HasIndex("LandRightsStatusId");

                    b.HasIndex("PriceTypeId");

                    b.ToTable("BuildingSurveyDataSheet");
                });

            modelBuilder.Entity("vpmc_backend.Models.LandAppraisalObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Object")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Land_AppraisalObject");
                });

            modelBuilder.Entity("vpmc_backend.Models.LandAssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Land_AssetType");
                });

            modelBuilder.Entity("vpmc_backend.Models.LandEvaluationRightsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Land_EvaluationRightsType");
                });

            modelBuilder.Entity("vpmc_backend.Models.LandLandRightsStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Land_LandRightsStatus");
                });

            modelBuilder.Entity("vpmc_backend.Models.LandPriceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Land_PriceType");
                });

            modelBuilder.Entity("vpmc_backend.Models.LandSurveyDataSheet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppraisalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppraisalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppraisalObjectId")
                        .HasColumnType("int");

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<string>("BuildAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildAddressCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildAddressVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BuildingCoverageRatio")
                        .HasColumnType("float");

                    b.Property<int>("EvaluationRightsTypeId")
                        .HasColumnType("int");

                    b.Property<double>("FloorAreaRatio")
                        .HasColumnType("float");

                    b.Property<DateTime>("InspectionDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("LandArea")
                        .HasColumnType("float");

                    b.Property<string>("LandMarkCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandRightsHolding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandRightsOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandRightsStatusId")
                        .HasColumnType("int");

                    b.Property<string>("LandUses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherRights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("SurveyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurveyorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranscriptPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValueOpinionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppraisalObjectId");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("EvaluationRightsTypeId");

                    b.HasIndex("LandRightsStatusId");

                    b.HasIndex("PriceTypeId");

                    b.ToTable("LandSurveyDataSheet");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkAppraisalObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Object")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_AppraisalObject");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkAssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_AssetType");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkAssignMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParkAssignMethod");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkBuildingRightsStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_BuildingRightsStatus");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkBuildingStructure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Structure")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_BuildingStructure");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkBuildingUsage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Usage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_BuildingUsage");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkEvaluationRightsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_EvaluationRightsType");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkLandRightsStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_LandRightsStatus");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParkMethod");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkPriceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Park_PriceType");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkSurveyDataSheet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("AllowSuv")
                        .HasColumnType("bit");

                    b.Property<string>("AppraisalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppraisalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppraisalObjectId")
                        .HasColumnType("int");

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<int>("AssignMethodId")
                        .HasColumnType("int");

                    b.Property<string>("BuildAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildAddressCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildAddressVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildMarkVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BuildingCoverageRatio")
                        .HasColumnType("float");

                    b.Property<int>("BuildingDownFloor")
                        .HasColumnType("int");

                    b.Property<DateTime>("BuildingFinishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BuildingRightsHolding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingRightsOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuildingRightsStatusId")
                        .HasColumnType("int");

                    b.Property<int>("BuildingStructureId")
                        .HasColumnType("int");

                    b.Property<int>("BuildingUpFloor")
                        .HasColumnType("int");

                    b.Property<int>("BuildingUsageId")
                        .HasColumnType("int");

                    b.Property<int>("EvaluationRightsTypeId")
                        .HasColumnType("int");

                    b.Property<double>("FloorAreaRatio")
                        .HasColumnType("float");

                    b.Property<DateTime>("InspectionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LandMarkCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMarkVillage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandRightsHolding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandRightsOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandRightsStatusId")
                        .HasColumnType("int");

                    b.Property<string>("LandUses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherRights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ParkArea")
                        .HasColumnType("float");

                    b.Property<int?>("ParkBuildingStructureId")
                        .HasColumnType("int");

                    b.Property<double>("ParkHeight")
                        .HasColumnType("float");

                    b.Property<int>("ParkMethodId")
                        .HasColumnType("int");

                    b.Property<int>("ParkTypeId")
                        .HasColumnType("int");

                    b.Property<double>("ParkWidth")
                        .HasColumnType("float");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("SurveyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SurveyFloor")
                        .HasColumnType("int");

                    b.Property<string>("SurveyorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranscriptPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValueOpinionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppraisalObjectId");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("AssignMethodId");

                    b.HasIndex("BuildingRightsStatusId");

                    b.HasIndex("BuildingStructureId");

                    b.HasIndex("BuildingUsageId");

                    b.HasIndex("EvaluationRightsTypeId");

                    b.HasIndex("LandRightsStatusId");

                    b.HasIndex("ParkBuildingStructureId");

                    b.HasIndex("ParkMethodId");

                    b.HasIndex("ParkTypeId");

                    b.HasIndex("PriceTypeId");

                    b.ToTable("ParkSurveyDataSheet");
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParkType");
                });

            modelBuilder.Entity("vpmc_backend.Models.BuildingSurveyDataSheet", b =>
                {
                    b.HasOne("vpmc_backend.Models.BuildingAppraisalObject", "AppraisalObject")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("AppraisalObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingAssetType", "AssetType")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingBuildingRightsStatus", "BuildingRightsStatus")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("BuildingRightsStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingBuildingStructure", "BuildingStructure")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("BuildingStructureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingBuildingUsage", "BuildingUsage")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("BuildingUsageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingEvaluationRightsType", "EvaluationRightsType")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("EvaluationRightsTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingLandRightsStatus", "LandRightsStatus")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("LandRightsStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingPriceType", "PriceType")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("PriceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("vpmc_backend.Models.LandSurveyDataSheet", b =>
                {
                    b.HasOne("vpmc_backend.Models.LandAppraisalObject", "AppraisalObject")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("AppraisalObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.LandAssetType", "AssetType")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.LandEvaluationRightsType", "EvaluationRightsType")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("EvaluationRightsTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.LandLandRightsStatus", "LandRightsStatus")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("LandRightsStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.LandPriceType", "PriceType")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("PriceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("vpmc_backend.Models.ParkSurveyDataSheet", b =>
                {
                    b.HasOne("vpmc_backend.Models.ParkAppraisalObject", "AppraisalObject")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("AppraisalObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkAssetType", "AssetType")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkAssignMethod", "AssignMethod")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("AssignMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkBuildingRightsStatus", "BuildingRightsStatus")
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("BuildingRightsStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.BuildingBuildingStructure", "BuildingStructure")
                        .WithMany()
                        .HasForeignKey("BuildingStructureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkBuildingUsage", "BuildingUsage")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("BuildingUsageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkEvaluationRightsType", "EvaluationRightsType")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("EvaluationRightsTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkLandRightsStatus", "LandRightsStatus")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("LandRightsStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkBuildingStructure", null)
                        .WithMany("SurveyDataSheet")
                        .HasForeignKey("ParkBuildingStructureId");

                    b.HasOne("vpmc_backend.Models.ParkMethod", "ParkMethod")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("ParkMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkType", "ParkType")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("ParkTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vpmc_backend.Models.ParkPriceType", "PriceType")
                        .WithMany("SurveyDataSheets")
                        .HasForeignKey("PriceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
