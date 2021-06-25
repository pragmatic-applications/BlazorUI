using System.Globalization;

namespace BlazorUI.Shared.UIShared
{
  public partial class HeadingComponent
  {
    private static readonly TextInfo tinfo = CultureInfo.CurrentCulture.TextInfo;
    private readonly string headingText = tinfo.ToTitleCase("welcome to blazor!");
    private string headingFontStyle = "normal";

    // Orig
    //private readonly bool italicsCheck = false;
    private bool italicsCheck = false;

    // When UpdateHeading is executed, italicsCheck determines 
    // the value of headingFontStyle to set the font style of the 
    // heading.
    public void UpdateHeading()
    {
      this.headingFontStyle = this.italicsCheck ? "italic" : "normal";
    }
  }
}
