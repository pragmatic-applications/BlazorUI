using System.Collections.Generic;

using BlazorUI.Shared.UIShared;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UICard
{
  public partial class Card : ComponentBase, ICard, IHandleChildStateChanges
  {
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string CssRule { get; set; }

    private readonly List<CardBody> bodies = new List<CardBody>();

    public void AddBody(CardBody body)
    {
      this.bodies.Add(body);
      this.StateHasChanged();
    }

    private CardHeader header;
    public void SetHeader(CardHeader header)
    {
      this.header = header;
      this.StateHasChanged();
    }

    private CardFooter footer;
    public void SetFooter(CardFooter footer)
    {
      this.footer = footer;
      this.StateHasChanged();
    }

    public void ChildStateChanged() => this.StateHasChanged();
  }
}
