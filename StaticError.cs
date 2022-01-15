// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    public partial class StaticError
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

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticError"/> class.
        /// </summary>
        public StaticError()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticError"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public StaticError( Exception ext )
        {
            InitializeComponent();
            Exception = ext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticError"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public StaticError( string message = "" )
        {
            InitializeComponent();
            Text = message;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SetText( string message )
        {
            Text = message;
        }
    }
}
