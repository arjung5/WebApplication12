// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication12.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using WebApplication12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using WebApplication12.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Counter.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Counter.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Counter.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Counter.razor"
       
    private string responseBody;

    private async Task PostRequest()
    {
        DateTime dateTime = DateTime.UtcNow.Date;
        var dateInp = dateTime.ToString("dd/MM/yyyy");
        var requestMessage = new HttpRequestMessage()
        {
            Method = new HttpMethod("GET"),
            RequestUri = new Uri("https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByPin?pincode=110085&date=09-06-2021&vaccine=COVISHIELD"),
            //Content =
            //    JsonContent.Create(new TodoItem
            //    {
            //        Name = "My New Todo Item",
            //        IsComplete = false
            //    })

        };
        var response = await Http.SendAsync(requestMessage);
        var responseStatusCode = response.StatusCode;

        responseBody = await response.Content.ReadAsStringAsync();
        //var tokenResult = await TokenProvider.RequestAccessToken();

        //if (tokenResult.TryGetToken(out var token))
        //{
        //    requestMessage.Headers.Authorization =
        //        new AuthenticationHeaderValue("Bearer", token.Value);

        //    requestMessage.Content.Headers.TryAddWithoutValidation(
        //        "x-custom-header", "value");

        //    var response = await Http.SendAsync(requestMessage);
        //    var responseStatusCode = response.StatusCode;

        //    responseBody = await response.Content.ReadAsStringAsync();
        //}
    }

    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591