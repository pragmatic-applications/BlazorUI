using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Shared.UIShared
{
  public partial class HTTPRequestTester
  {
    [Inject]
    public HttpClient Http { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private string uri = "https://localhost:10000/api/TodoItems";
    private string method = "POST";
    private string requestBody = @"{""name"":""A New Todo Item"",""isComplete"":false}";

    private readonly List<RequestHeader> requestHeaders = new List<RequestHeader>()
    {
        new RequestHeader() { Name = "Content-Type", Value = "application/json" },
        new RequestHeader() { Name = "Authorization", Value = "Bearer MHrHDcEfxjoYZgeFONFh7HgQ" }
    };

    private HttpStatusCode? responseStatusCode;
    private string responseBody;
    private string responseHeaders;

    private async void DoRequest()
    {
      this.responseStatusCode = null;

      try
      {
        var requestMessage = new HttpRequestMessage()
        {
          Method = new HttpMethod(this.method),
          RequestUri = new Uri(this.uri),
          Content = string.IsNullOrEmpty(this.requestBody) ? null : new StringContent(this.requestBody)
        };

        foreach(var header in this.requestHeaders)
        {
          // StringContent automatically adds its own Content-Type header with default value "text/plain"
          // If the developer is trying to specify a content type explicitly, we need to replace the default value,
          // rather than adding a second Content-Type header.
          if(header.Name.Equals("Content-Type", StringComparison.OrdinalIgnoreCase) && requestMessage.Content != null)
          {
            requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(header.Value);
            continue;
          }

          if(!requestMessage.Headers.TryAddWithoutValidation(header.Name, header.Value))
          {
            requestMessage.Content?.Headers.TryAddWithoutValidation(header.Name, header.Value);
          }
        }

        var response = await this.Http.SendAsync(requestMessage);
        this.responseStatusCode = response.StatusCode;
        this.responseBody = await response.Content.ReadAsStringAsync();
        var allHeaders = response.Headers.Concat(response.Content?.Headers ?? Enumerable.Empty<KeyValuePair<string, IEnumerable<string>>>());
        this.responseHeaders = string.Join(Environment.NewLine, allHeaders.Select(pair => $"{pair.Key}: {pair.Value.First()}").ToArray());
      }
      catch(Exception ex)
      {
        if(ex is AggregateException)
        {
          ex = ex.InnerException;
        }
        this.responseStatusCode = System.Net.HttpStatusCode.SeeOther;
        this.responseBody = ex.Message + Environment.NewLine + ex.StackTrace;
      }

      this.StateHasChanged();
    }

    private void AddHeader() => this.requestHeaders.Add(new RequestHeader());

    private void RemoveHeader(RequestHeader header) => this.requestHeaders.Remove(header);

    private class RequestHeader
    {
      public string Name { get; set; }
      public string Value { get; set; }
    }
  }
}
