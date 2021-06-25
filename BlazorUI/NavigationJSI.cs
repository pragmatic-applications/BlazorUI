using System;
using System.Threading.Tasks;

using Microsoft.JSInterop;

namespace BlazorUI
{
    public class NavigationJSI : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public NavigationJSI(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/BlazorUI/js/NavigationJSI.js").AsTask());
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        // S NNTest
        public async ValueTask OnCloseSidebar(string element)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("onCloseSidebar", element);
        }

        public async ValueTask OnToggleSidebar(string element)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("onToggleSidebar", element);
        }

        public async ValueTask LoadNavigation()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("loadNavigation");
        }
        // E NNTest

        public async ValueTask DisposeAsync()
        {
            if(moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
