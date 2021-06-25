using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public interface ITab
  {
    RenderFragment ChildContent { get; }
  }
}
