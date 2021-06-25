using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
  {
    [Parameter]
    public virtual ElementType ElementType { get; set; } = ElementType.Div;

    protected override ElementType ContainerElementType => this.ElementType;
  }
}
