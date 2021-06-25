using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared
{
    public class FormCore : ComponentBase
    {
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public string ButtonTextParameter { get; set; }
        [Parameter] public string FormTitleParameter { get; set; }
        [Parameter] public FormMode FormModeParameter { get; set; } = FormMode.Create;

        public string CategoryId { get; set; } = "0";

        public int GetCategoryId(string categoryId)
        {
            int.TryParse(categoryId, out var result);

            return result;
        }
    }
}
