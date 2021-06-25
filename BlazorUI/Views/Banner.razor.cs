using BlazorUI.Shared;

namespace BlazorUI.Views
{
    public partial class Banner : CoreComponent //:  //AppCoreComponent //ComponentBase
    {
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if(string.IsNullOrWhiteSpace(this.BannerTitleParameter))
            {
                this.HeaderTitle = "MVC & Razor UI";
            }
            else if(this.BannerTitleParameter == "Page Not Found")
            {
                this.HeaderTitle = this.BannerTitleParameter;
                this.AppName = this.BannerTitleParameter;
            }
            else
            {
                this.HeaderTitle = this.AppNameParameter + " - " + this.BannerTitleParameter;
                this.AppName = this.AppNameParameter;
            }
        }
    }
}
