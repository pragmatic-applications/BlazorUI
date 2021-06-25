using BlazorUI.Shared.UIShared;

namespace BlazorUI.Shared.UICard
{
  public partial class CardFooter : ContainerChildElement<ICard>
  {
    protected override void Register(ICard parent)
    {
      parent.SetFooter(this);
    }

    protected override string ContainerCssClass => "card-footer text-muted";
  }
}
