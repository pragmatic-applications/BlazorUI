using BlazorUI.Shared.UIShared;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UICard
{
  public partial class CardText : ContainerChildElement<ICardBody>
  {
    protected override void Register(ICardBody parent) => parent.AddText(this);

    [Parameter]
    public string CssRule { get; set; }
    protected override string ContainerCssClass => this.CssRule;

    //protected override string ContainerCssClass => "card-text";
    protected override ElementType ContainerElementType => ElementType.P;
  }
}
