﻿using Lite;

using BlazorUI.Shared;

using Interfaces;

namespace BlazorUI.Views
{
    public partial class Pager : CoreComponent //AppComponent
    {
        public PagerData PagerDataValue { get; set; }
        public ISelect SelectParameterValue { get; set; }

        protected override void OnParametersSet()
        {
            this.PagerDataValue = this.PagerDataParameter;
            this.SelectParameterValue = this.SelectParameter;

            this.SpreadValue = this.SpreadParameter;
        }
    }
}