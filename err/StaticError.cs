// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    public partial class StaticError
    {
        public StaticError()
        {
            InitializeComponent();
        }

        public StaticError( Exception ext )
        {
            InitializeComponent();
            Exception = ext;
        }

        public StaticError( string message )
        {
            InitializeComponent();
            Text = message;
        }

        public Exception Exception { get; }

        public new string Text { get; set; }

        public void SetText()
        {
        }
    }
}
