using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public abstract class ChildElement<TParent> : ComponentBase
  {
    [CascadingParameter]
    TParent Parent { get; set; }

    protected override void OnInitialized()
    {
      base.OnInitialized();
      if(this.Parent != null)
      {
        this.Register(this.Parent);
      }
    }

    protected abstract void Register(TParent parent);
    public abstract RenderFragment RenderContent { get; }

    protected new void StateHasChanged()
    {
      base.StateHasChanged();
      var cscHandler = this.Parent as IHandleChildStateChanges;
      if(cscHandler != null)
      {
        cscHandler.ChildStateChanged();
      }
    }
  }
}
