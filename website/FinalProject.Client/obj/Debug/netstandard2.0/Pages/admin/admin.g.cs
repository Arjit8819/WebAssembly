#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00af2f1ea9c7a46771258aa0a4002de2d9255c26"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalProject.Client.Pages.admin
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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/admin")]
    public class admin : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 4 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\admin.cshtml"
 if (to)
{


#line default
#line hidden
            builder.OpenElement(0, "input");
            builder.AddAttribute(1, "type", "text");
            builder.AddAttribute(2, "placeholder", "firstname");
            builder.AddAttribute(3, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(name));
            builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => name = __value, name));
            builder.CloseElement();
            builder.AddContent(5, "\n");
            builder.OpenElement(6, "input");
            builder.AddAttribute(7, "type", "text");
            builder.AddAttribute(8, "placeholder", "firstname");
            builder.AddAttribute(9, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(password));
            builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => password = __value, password));
            builder.CloseElement();
            builder.AddContent(11, "\n");
            builder.OpenElement(12, "button");
            builder.AddAttribute(13, "type", "submit");
            builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(login));
            builder.AddContent(15, "submit");
            builder.CloseElement();
            builder.AddContent(16, "\n");
            builder.OpenElement(17, "button");
            builder.AddAttribute(18, "type", "submit");
            builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(shortlist));
            builder.AddContent(20, "test");
            builder.CloseElement();
            builder.AddContent(21, "\n");
            builder.OpenElement(22, "h3");
            builder.AddAttribute(23, "style", "color : red");
            builder.AddContent(24, error);
            builder.CloseElement();
            builder.AddContent(25, "\n");
#line 12 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\admin.cshtml"
}

#line default
#line hidden
#line 13 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\admin.cshtml"
 if (from) {


#line default
#line hidden
            builder.AddContent(26, "    ");
            builder.OpenComponent<FinalProject.Client.Pages.admin.adminarea>(27);
            builder.CloseComponent();
            builder.AddContent(28, "\n");
#line 16 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\admin.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 20 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\admin.cshtml"
 
    string name;
    string password;
    string error;
    Boolean to = true;
    Boolean from = false;

    private void login()
    {

        if (name == "admin" && password == "admin")
        {
            to = false;
            from = true;
        }
        else {
            error = "Please check you credentials";

        }
    }
    private void shortlist() {

        UriHelper.NavigateTo("/test");

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
