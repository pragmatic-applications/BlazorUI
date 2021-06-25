using System.Collections.Generic;

using BlazorUI.Shared.UIShared;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UICard
{
  public partial class CardBody : ChildElement<ICard>, ICardBody
  {
    protected override void Register(ICard parent)
    {
      parent.AddBody(this);
    }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private CardTitle title;
    public void SetTitle(CardTitle title)
    {
      this.title = title;
      this.StateHasChanged();
    }

    private readonly List<CardText> texts = new List<CardText>();

    public void AddText(CardText text)
    {
      this.texts.Add(text);
      this.StateHasChanged();
    }

    private readonly List<CardLink> links = new List<CardLink>();

    public void AddLink(CardLink link)
    {
      this.links.Add(link);
      this.StateHasChanged();
    }

    public override RenderFragment RenderContent => (builder =>
    {
      var i = 0;
      builder.OpenElement(i++, "div");
      builder.AddAttribute(i++, "class", "card-body");
      if(this.title != null)
      {
        builder.AddContent(i++, this.title.RenderContent);
      }

      foreach(var text in this.texts)
      {
        builder.AddContent(i++, text.RenderContent);
      }

      foreach(var link in this.links)
      {
        builder.AddContent(i++, link.RenderContent);
      }

      builder.CloseElement();
    });
  }
}
