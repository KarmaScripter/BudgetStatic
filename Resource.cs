// // <copyright file = "Resource.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public static class Resource
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public static NameValueCollection Settings { get; } = ConfigurationManager.AppSettings;

        // ***************************************************************************************************************************
        // ****************************************       Image Sources       ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The object class icons
        /// </summary>
        public static readonly string ObjectClassIcons = Resource.Settings[ "ObjectClassIcons" ];

        /// <summary>
        /// The summary
        /// </summary>
        public static readonly string Summary = Resource.Settings[ "SummaryImages" ];

        /// <summary>
        /// The funds
        /// </summary>
        public static readonly string Funds = Resource.Settings[ "FundImages" ];

        /// <summary>
        /// The divisions
        /// </summary>
        public static readonly string Divisions = Resource.Settings[ "DivisionImages" ];

        /// <summary>
        /// The databases
        /// </summary>
        public static readonly string Databases = Resource.Settings[ "Database" ];

        /// <summary>
        /// The data icons
        /// </summary>
        public static readonly string DataIcons = Resource.Settings[ "DataIcons" ];

        /// <summary>
        /// The outlays
        /// </summary>
        public static readonly string Outlays = Resource.Settings[ "OutlayImages" ];

        /// <summary>
        /// The office icons
        /// </summary>
        public static readonly string OfficeIcons = Resource.Settings[ "OfficeIcons" ];

        /// <summary>
        /// The navigation icons
        /// </summary>
        public static readonly string NavigationIcons = Resource.Settings[ "NavigationIcons" ];

        /// <summary>
        /// The codec icons
        /// </summary>
        public static readonly string CodecIcons = Resource.Settings[ "CodecIcons" ];

        /// <summary>
        /// The outlay icons
        /// </summary>
        public static readonly string OutlayIcons = Resource.Settings[ "OutlayIcons" ];

        /// <summary>
        /// The file icons
        /// </summary>
        public static readonly string FileIcons = Resource.Settings[ "FileIcons" ];

        /// <summary>
        /// The object class images
        /// </summary>
        public static readonly string ObjectClassImages = Resource.Settings[ "ObjectClassImages" ];

        /// <summary>
        /// The provider icons
        /// </summary>
        public static readonly string ProviderIcons = Resource.Settings[ "ProviderIcons" ];

        /// <summary>
        /// The math icons
        /// </summary>
        public static readonly string MathIcons = Resource.Settings[ "MathIcons" ];

        /// <summary>
        /// The interface icons
        /// </summary>
        public static readonly string InterfaceIcons = Resource.Settings[ "InterfaceIcons" ];

        /// <summary>
        /// The folder icons
        /// </summary>
        public static readonly string FolderIcons = Resource.Settings[ "FolderIcons" ];

        /// <summary>
        /// The division caption
        /// </summary>
        public static readonly string DivisionCaption = Resource.Settings[ "DivisionCaption" ];

        /// <summary>
        /// The division icons
        /// </summary>
        public static readonly string DivisionIcons = Resource.Settings[ "DivisionIcons" ];

        /// <summary>
        /// The division text icon
        /// </summary>
        public static readonly string DivisionTextIcon = Resource.Settings[ "DivisionTextIcon" ];

        /// <summary>
        /// The main form images
        /// </summary>
        public static readonly string MainFormImages = Resource.Settings[ "MainFormImages" ];

        /// <summary>
        /// The execution images
        /// </summary>
        public static readonly string ExecutionImages = Resource.Settings[ "ExecutionImages" ];

        /// <summary>
        /// The execution icons
        /// </summary>
        public static readonly string ExecutionIcons = Resource.Settings[ "ExecutionIcons" ];

        /// <summary>
        /// The tool bar
        /// </summary>
        public static readonly string ToolBar = Resource.Settings[ "ToolBar" ];

        // ***************************************************************************************************************************
        // ****************************************         DataSources       ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The division sources
        /// </summary>
        public static readonly Source[] DivisionSources =
        {
            Source.EJ,
            Source.ECAD,
            Source.ORA,
            Source.ORC,
            Source.SEMD,
            Source.MSD,
            Source.WD,
            Source.XA,
            Source.ARD,
            Source.WSA,
            Source.MDR,
            Source.WCF,
            Source.LCARD,
            Source.LSASD
        };

        /// <summary>
        /// The appropriation sources
        /// </summary>
        public static readonly Source[] AppropriationSources =
        {
            Source.EPM,
            Source.SF6A,
            Source.STAG,
            Source.DeepWaterHorizon,
            Source.CategoricalGrants,
            Source.CleanWaterStateRevolvingFund,
            Source.DrinkingWaterStateRevolvingFund,
            Source.SpecialProjectsAndEarmarks,
            Source.LUST,
            Source.OilSpill,
            Source.Superfund,
            Source.SpecialAccounts,
            Source.LustSupplemental,
            Source.SuperfundSupplemental
        };

        /// <summary>
        /// The object class sources
        /// </summary>
        public static readonly Source[] ObjectClassSources =
        {
            Source.Contracts,
            Source.FTE,
            Source.Expenses,
            Source.Grants,
            Source.Payroll,
            Source.WCF,
            Source.Travel,
            Source.SiteTravel,
            Source.NonSiteTravel
        };

        /// <summary>
        /// The chart types
        /// </summary>
        public static readonly string[] ChartTypes = Enum.GetNames( typeof( ChartType ) );

        /// <summary>
        /// The reference sources
        /// </summary>
        public static readonly Source[] ReferenceSources =
        {
            Source.Accounts,
            Source.Activity,
            Source.AllowanceHolders,
            Source.Appropriations,
            Source.ControlNumbers,
            Source.BudgetObjectClass,
            Source.Divisions,
            Source.Employees,
            Source.FinanceObjectClass,
            Source.Funds,
            Source.Goals,
            Source.WorkforceData,
            Source.HumanResourceOrganizations,
            Source.NationalPrograms,
            Source.Objectives,
            Source.Organizations,
            Source.ResourcePlanningOffices,
            Source.ProgramAreas,
            Source.ProgramProjects,
            Source.Programs,
            Source.ResponsibilityCenters,
            Source.InformationTechnology,
            Source.WorkCodes,
            Source.FiscalYears,
            Source.AppropriationBills
        };

        /// <summary>
        /// The allocation sources
        /// </summary>
        public static readonly Source[] AllocationSources =
        {
            Source.PRC,
            Source.Allocations,
            Source.DivisionAuthority,
            Source.DivisionExecution,
            Source.RegionAuthority,
            Source.RegionExecution,
            Source.Transfers,
            Source.ControlNumbers,
            Source.InternalTransfers,
            Source.ExternalTransfers,
            Source.Contracts,
            Source.FTE,
            Source.Expenses,
            Source.Grants,
            Source.Payroll,
            Source.Contracts,
            Source.Travel,
            Source.SiteTravel,
            Source.EPM,
            Source.SF6A,
            Source.STAG,
            Source.DeepWaterHorizon,
            Source.LUST,
            Source.OilSpill,
            Source.Superfund,
            Source.SpecialAccounts,
            Source.SuperfundSupplemental,
            Source.LustSupplemental,
            Source.Awards,
            Source.TimeOff,
            Source.Overtime,
            Source.EJ,
            Source.ECAD,
            Source.ORA,
            Source.ORC,
            Source.SEMD,
            Source.MSD,
            Source.WD,
            Source.XA,
            Source.ARD,
            Source.WSA,
            Source.MDR,
            Source.WCF,
            Source.LCARD,
            Source.LSASD
        };

        /// <summary>
        /// The authority sources
        /// </summary>
        public static readonly Source[] AuthoritySources =
        {
            Source.PRC,
            Source.Allocations,
            Source.Transfers,
            Source.DivisionAuthority,
            Source.DivisionExecution,
            Source.RegionAuthority,
            Source.RegionExecution,
            Source.CleanWaterStateRevolvingFund,
            Source.InternalTransfers,
            Source.ExternalTransfers,
            Source.Contracts,
            Source.FTE,
            Source.Expenses,
            Source.Grants,
            Source.Payroll,
            Source.Contracts,
            Source.Travel,
            Source.SiteTravel,
            Source.EPM,
            Source.SF6A,
            Source.STAG,
            Source.DeepWaterHorizon,
            Source.LUST,
            Source.OilSpill,
            Source.Superfund,
            Source.SpecialAccounts,
            Source.SuperfundSupplemental,
            Source.LustSupplemental,
            Source.Awards,
            Source.TimeOff,
            Source.Overtime,
            Source.EJ,
            Source.ECAD,
            Source.ORA,
            Source.ORC,
            Source.SEMD,
            Source.MSD,
            Source.DrinkingWaterStateRevolvingFund,
            Source.WD,
            Source.XA,
            Source.ARD,
            Source.WSA,
            Source.MDR,
            Source.WCF,
            Source.LCARD,
            Source.LSASD,
            Source.BudgetLevels,
            Source.NonSiteTravel,
            Source.Reprogrammings,
            Source.SpecialProjectsAndEarmarks,
            Source.Transfers
        };

        /// <summary>
        /// The supplemental sources
        /// </summary>
        public static readonly Source[] SupplementalSources =
        {
            Source.Supplemental,
            Source.Awards,
            Source.Overtime,
            Source.TimeOff
        };

        /// <summary>
        /// The outlay sources
        /// </summary>
        public static readonly Source[] OutlaySources =
        {
            Source.Outlays,
            Source.Payments,
            Source.Requisitions,
            Source.Procurements,
            Source.TravelObligations,
            Source.PayrollHours,
            Source.PayrollObligations,
            Source.Utilization,
            Source.BudgetLevels,
            Source.StatusOfFunds,
            Source.UnliquidatedObligations,
            Source.Obligations,
            Source.Deobligations,
            Source.Commitments,
            Source.OpenCommitments,
            Source.Vendors,
            Source.Sites,
            Source.LeaveProjections,
            Source.RegionExecution,
            Source.DivisionExecution,
            Source.PurchaseActivity
        };

        /// <summary>
        /// The sources
        /// </summary>
        public static readonly string[] Sources = Enum.GetNames( typeof( Source ) );

        /// <summary>
        /// The providers
        /// </summary>
        public static readonly string[] Providers = Enum.GetNames( typeof( Provider ) );

        /// <summary>
        /// The fields
        /// </summary>
        public static readonly string[] Fields = Enum.GetNames( typeof( Field ) );

        /// <summary>
        /// The numerics
        /// </summary>
        public static readonly string[] Numerics = Enum.GetNames( typeof( Numeric ) );

        /// <summary>
        /// The primary keys
        /// </summary>
        public static readonly string[] PrimaryKeys = Enum.GetNames( typeof( PrimaryKey ) );

        /// <summary>
        /// The extensions
        /// </summary>
        public static readonly string[] Extensions = Enum.GetNames( typeof( EXT ) );

        /// <summary>
        /// The image resources
        /// </summary>
        public static readonly string[] ImageResources = Enum.GetNames( typeof( ImageSource ) );

        /// <summary>
        /// The charts
        /// </summary>
        public static readonly string[] Charts = Enum.GetNames( typeof( ChartType ) );

        /// <summary>
        /// The tools
        /// </summary>
        public static readonly string[] Tools = Enum.GetNames( typeof( Tool ) );
    }
}
