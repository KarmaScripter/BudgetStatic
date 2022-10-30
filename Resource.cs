// <copyright file = "Resource.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using static System.Configuration.ConfigurationManager;

    /// <summary>
    /// 
    /// </summary>
    public static class Resource
    {
        /// <summary>
        /// The summary
        /// </summary>
        public static string Summary = !string.IsNullOrEmpty( AppSettings[ "SummaryImages" ] )
            ? AppSettings[ "SummaryImages" ]
            : string.Empty;

        /// <summary>
        /// The fund images
        /// </summary>
        public static string FundImages = AppSettings[ "FundImages" ];

        /// <summary>
        /// The databases
        /// </summary>
        public static string Databases = AppSettings[ "DatabaseImages" ];

        /// <summary>
        /// The data images
        /// </summary>
        public static string DataImages = AppSettings[ "DataImages" ];

        /// <summary>
        /// The office images
        /// </summary>
        public static string OfficeImages = AppSettings[ "OfficeImages" ];

        /// <summary>
        /// The navigation images
        /// </summary>
        public static string NavigationImages = AppSettings[ "NavigationImages" ];

        /// <summary>
        /// The codec images
        /// </summary>
        public static readonly string CodecImages = AppSettings[ "CodecImages" ];

        /// <summary>
        /// The outlay images
        /// </summary>
        public static readonly string OutlayImages = AppSettings[ "OutlayImages" ];

        /// <summary>
        /// The file images
        /// </summary>
        public static readonly string FileImages = AppSettings[ "FileImages" ];

        /// <summary>
        /// The object class images
        /// </summary>
        public static readonly string ObjectClassImages = AppSettings[ "ObjectClassImages" ];

        /// <summary>
        /// The provider images
        /// </summary>
        public static readonly string ProviderImages = AppSettings[ "ProviderImages" ];

        /// <summary>
        /// The math images
        /// </summary>
        public static readonly string MathImages = AppSettings[ "MathImages" ];

        /// <summary>
        /// The interface images
        /// </summary>
        public static readonly string InterfaceImages = AppSettings[ "InterfaceImages" ];

        /// <summary>
        /// The folder images
        /// </summary>
        public static readonly string FolderImages = AppSettings[ "FolderImages" ];

        /// <summary>
        /// The division caption
        /// </summary>
        public static readonly string DivisionCaption = AppSettings[ "DivisionCaption" ];

        /// <summary>
        /// The division images
        /// </summary>
        public static readonly string DivisionImages = AppSettings[ "DivisionImages" ];

        /// <summary>
        /// The division text icon
        /// </summary>
        public static readonly string DivisionTextIcon = AppSettings[ "DivisionTextIcon" ];

        /// <summary>
        /// The main form images
        /// </summary>
        public static readonly string MainFormImages = AppSettings[ "MainFormImages" ];

        /// <summary>
        /// The execution images
        /// </summary>
        public static readonly string ExecutionImages = AppSettings[ "ExecutionImages" ];

        /// <summary>
        /// The tool bar images
        /// </summary>
        public static readonly string ToolBarImages = AppSettings[ "ToolBarImages" ];
    }
}