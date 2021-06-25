using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public partial class TabSet
  {
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public ITab ActiveTab { get; private set; }

    public void AddTab(ITab tab)
    {
      if(this.ActiveTab == null)
      {
        this.SetActiveTab(tab);
      }
    }

    public void SetActiveTab(ITab tab)
    {
      if(this.ActiveTab != tab)
      {
        this.ActiveTab = tab;
        this.StateHasChanged();
      }
    }
  }
}
