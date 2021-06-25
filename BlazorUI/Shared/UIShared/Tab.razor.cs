using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public partial class Tab : ITab
  {
    [CascadingParameter]
    public TabSet ContainerTabSet { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private string TitleCssClass => this.ContainerTabSet.ActiveTab == this ? "active" : null;

    protected override void OnInitialized() => this.ContainerTabSet.AddTab(this);

    private void ActivateTab() => this.ContainerTabSet.SetActiveTab(this);
  }
}
