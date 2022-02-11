// <copyright file = "Error.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Syncfusion.WinForms.Controls;

    internal partial class Error : SfForm
    {
        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public Exception Exception { get; }

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        public new string Text { get; set; }

        public Error()
        {
            InitializeComponent();

            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb( 15, 161, 212 );
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml( "#343434" );
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;

            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font( "Microsoft Sans Serif",
                11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ( (byte)( 0 ) ) );

            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;

            this.Style.TitleBar.TextVerticalAlignment =
                System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public Error( Exception ext )
        {
            InitializeComponent();
            Exception = ext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public Error( string message = "" )
        {
            InitializeComponent();
            Text = message;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SetText( string message = "" )
        {
            Text = message;
        }
    }

}
