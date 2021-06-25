using BlazorUI.Shared.UIShared;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UICard
{
  public partial class CardLink : ChildElement<ICardBody>
  {
    protected override void Register(ICardBody parent)
    {
      parent.AddLink(this);
    }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Target { get; set; }

    public override RenderFragment RenderContent => (builder =>
    {
      builder.OpenElement(0, "a");
      builder.AddAttribute(1, "class", "card-link");
      builder.AddAttribute(2, "href", this.Target);
      builder.AddContent(3, this.ChildContent);
      builder.CloseElement();
    });
  }
}
