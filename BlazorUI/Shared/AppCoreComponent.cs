
//using Microsoft.AspNetCore.Components;

//namespace BlazorUI.Shared
//{
//    public class AppCoreComponent : CoreComponent
//    {
//        [Parameter] public bool IsPageIndexParameter { get; set; } = false;
//        [Parameter] public bool IsCrudParameter { get; set; } = false;
//        [Parameter] public bool IsPageAdminParameter { get; set; } = false;

//        public string UrlUpdate { get; set; }
//        public string UrlDelete { get; set; }

//        protected int ImageCount { get; set; } = 0;

//        public ISelect ItemSelect { get; set; }
//        [Parameter] public ISelect SelectParameter { get; set; }

//        protected virtual void ClearFields() { }


//        protected virtual void Reload()
//        {
//            this.ClearFields();
//            this.NavigationManager.NavigateTo("/");
//        }

//        protected void GoToPage(string pageToNavigateTo)
//        {
//            this.ClearFields();
//            this.StateHasChanged();
//            this.NavigationManager.NavigateTo(pageToNavigateTo);
//        }
//    }
//}
