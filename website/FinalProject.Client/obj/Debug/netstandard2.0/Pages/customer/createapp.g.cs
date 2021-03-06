#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createapp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb44816c8470aec1d9b14f28084aee928f0a98b"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalProject.Client.Pages.customer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using FinalProject.Client;
    using FinalProject.Shared;
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/createapp/{myvalue}")]
    public class createapp : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "body3");
            builder.AddMarkupContent(2, "\n    <br><br><br><br><br><br><br>\n    ");
            builder.OpenElement(3, "center");
            builder.AddContent(4, "\n\n        ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "container");
            builder.AddContent(7, "\n            ");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "class", "col-sm-6");
            builder.AddContent(10, "\n                ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class", "input-field col s6");
            builder.AddContent(13, "\n                    ");
            builder.OpenElement(14, "input");
            builder.AddAttribute(15, "style", "color:white");
            builder.AddAttribute(16, "type", "text");
            builder.AddAttribute(17, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(appname));
            builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => appname = __value, appname));
            builder.CloseElement();
            builder.AddContent(19, "\n                    ");
            builder.AddMarkupContent(20, "<label for=\"Appname\">Game Name</label>\n\n                    ");
            builder.OpenElement(21, "button");
            builder.AddAttribute(22, "class", "btn waves-effect waves-light");
            builder.AddAttribute(23, "type", "submit");
            builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(options));
            builder.AddContent(25, "\n                        Submit\n                        ");
            builder.AddMarkupContent(26, "<i class=\"material-icons right\">send</i>\n                    ");
            builder.CloseElement();
            builder.AddContent(27, "\n                    ");
            builder.OpenElement(28, "button");
            builder.AddAttribute(29, "class", "btn waves-effect waves-light");
            builder.AddAttribute(30, "type", "submit");
            builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(openback));
            builder.AddContent(32, "\n\n                        ");
            builder.AddMarkupContent(33, "<i class=\"material-icons right\">&lt;</i>back\n                    ");
            builder.CloseElement();
            builder.AddContent(34, "\n                ");
            builder.CloseElement();
            builder.AddContent(35, "\n            ");
            builder.CloseElement();
            builder.AddContent(36, "\n        ");
            builder.CloseElement();
            builder.AddContent(37, "\n    ");
            builder.CloseElement();
            builder.AddContent(38, "\n    ");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 34 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createapp.cshtml"
     

    [Parameter]
    private String myvalue { get; set; }

    String appname;

    Boolean a;

    public async void options()
    {

        string body = (myvalue + ":" + appname);

        a = await Http.SendJsonAsync<Boolean>(HttpMethod.Post, "/api/Login/appname", body);

    }

    public void openback()
    {

        UriHelper.NavigateTo($"/login/{myvalue}");
    }

    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
