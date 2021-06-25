using BlazorUI.Shared.UIShared;

namespace BlazorUI.Shared.UICard
{
  public partial class CardHeader : FlexibleContainerChildElement<ICard>
  {
    protected override void Register(ICard parent)
    {
      parent.SetHeader(this);
    }

    protected override string ContainerCssClass => "card-header";
  }
}
