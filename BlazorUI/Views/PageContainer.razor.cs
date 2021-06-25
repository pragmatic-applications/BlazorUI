using System.Collections.Generic;

using Lib_BrowserPlatform;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Views
{
    public partial class PageContainer
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public List<PageLink> NavLinks { get; set; }


        //[Inject] public IJSRuntime JSRuntime { get; set; }

        //[Inject] public NavigationJSI NavigationJSI { get; set; }

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    await base.OnAfterRenderAsync(firstRender);

        //    if(firstRender)
        //    {
        //        await this.NavigationJSI.LoadNavigation();
        //    }
        //}
    }
}
