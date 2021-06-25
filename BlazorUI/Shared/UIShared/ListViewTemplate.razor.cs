using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public partial class ListViewTemplate<TItem>
  {
    [Parameter]
    public RenderFragment<TItem> ItemTemplate { get; set; }

    [Parameter]
    public IReadOnlyList<TItem> Items { get; set; }
  }
}
