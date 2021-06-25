using System;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public partial class RedirectToLogin : ComponentBase
  {
    [Inject]
    public NavigationManager Navigation { get; set; }

    protected override void OnInitialized()
    {
      this.Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(this.Navigation.Uri)}");
    }
  }
}
