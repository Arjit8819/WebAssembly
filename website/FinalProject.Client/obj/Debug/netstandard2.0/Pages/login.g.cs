#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3529aabb86b392213ea16bb69a1abb3d707f95e8"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalProject.Client.Pages
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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/login/{myvalue}")]
    public class login : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 8 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"
 if (to)
{
    

#line default
#line hidden
#line 10 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"
     if (user == null)
    {

#line default
#line hidden
            builder.AddContent(0, "        ");
            builder.AddMarkupContent(1, "<h5>Loding...</h5>\n");
#line 13 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"
    }
    else
    {


#line default
#line hidden
            builder.AddContent(2, "        ");
            builder.OpenElement(3, "nav");
            builder.AddContent(4, "\n            ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "nav-wrapper grey darken-4 ");
            builder.AddContent(7, "\n                ");
            builder.AddMarkupContent(8, "<a href=\"#\" class=\"brand-logo\"><img class=\"circle\" height=\"50\" width=\"50\" src=\"/css/image/batman.jpg\">Gaming</a>\n\n\n                ");
            builder.OpenElement(9, "ul");
            builder.AddAttribute(10, "id", "nav-mobile");
            builder.AddAttribute(11, "class", "right hide-on-med-and-down");
            builder.AddContent(12, "\n\n                    ");
            builder.OpenElement(13, "li");
            builder.AddContent(14, "\n\n                        ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(15);
            builder.AddAttribute(16, "href", "/addinfo/" + user.username);
            builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(18, "\n                            ");
                builder2.OpenElement(19, "img");
                builder2.AddAttribute(20, "class", "circle");
                builder2.AddAttribute(21, "height", "40");
                builder2.AddAttribute(22, "width", "40");
                builder2.AddAttribute(23, "src", user.image);
                builder2.CloseElement();
                builder2.AddContent(24, "\n                            ");
                builder2.AddContent(25, user.yourname);
                builder2.AddContent(26, "\n                        ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(27, "\n\n                    ");
            builder.CloseElement();
            builder.AddContent(28, "\n\n                    ");
            builder.OpenElement(29, "li");
            builder.OpenElement(30, "p");
            builder.AddContent(31, "\n    Money left : ");
            builder.AddContent(32, user.money);
            builder.AddContent(33, "\n       \n    ");
            builder.AddContent(34, user.Appname);
            builder.AddContent(35, "    \n");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(36, "\n                    ");
            builder.OpenElement(37, "li");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(38);
            builder.AddAttribute(39, "href", "/");
            builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(41, "Logout");
            }
            ));
            builder.CloseComponent();
            builder.CloseElement();
            builder.AddContent(42, "\n\n                ");
            builder.CloseElement();
            builder.AddContent(43, "\n            ");
            builder.CloseElement();
            builder.AddContent(44, "\n        ");
            builder.CloseElement();
            builder.AddContent(45, "\n");
            builder.AddContent(46, "        ");
            builder.OpenElement(47, "div");
            builder.AddAttribute(48, "class", "container pull-right body1");
            builder.AddMarkupContent(49, "\n        <br>\n        <br>\n        ");
            builder.OpenElement(50, "button");
            builder.AddAttribute(51, "class", "btn btn-primary blue");
            builder.AddAttribute(52, "style", "margin:auto");
            builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(createapp));
            builder.AddContent(54, "Register Game");
            builder.CloseElement();
            builder.AddMarkupContent(55, "\n        <br>\n        <br>\n        ");
            builder.OpenElement(56, "button");
            builder.AddAttribute(57, "class", "btn btn-primary blue");
            builder.AddAttribute(58, "type", "submit");
            builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(start));
            builder.AddContent(60, "Upload/survey");
            builder.CloseElement();
            builder.AddMarkupContent(61, "\n        <br>\n        <br>\n        ");
            builder.OpenElement(62, "button");
            builder.AddAttribute(63, "class", "btn btn-primary blue");
            builder.AddAttribute(64, "type", "submit");
            builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(check));
            builder.AddContent(66, "Check survey");
            builder.CloseElement();
            builder.AddMarkupContent(67, "\n        <br>\n        <br>\n        ");
            builder.OpenElement(68, "button");
            builder.AddAttribute(69, "class", "btn btn-primary blue");
            builder.AddAttribute(70, "type", "submit");
            builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(payment));
            builder.AddContent(72, "Make payment");
            builder.CloseElement();
            builder.AddContent(73, "\n        ");
            builder.CloseElement();
            builder.AddContent(74, "\n");
#line 59 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"
    }

#line default
#line hidden
#line 59 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"
     
}

#line default
#line hidden
            builder.AddContent(75, "\n");
#line 62 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"
 if (info)
{

#line default
#line hidden
            builder.AddContent(76, "    ");
            builder.OpenElement(77, "div");
            builder.AddAttribute(78, "class", "row");
            builder.AddContent(79, "\n        ");
            builder.OpenComponent<FinalProject.Client.Pages.customer.info>(80);
            builder.CloseComponent();
            builder.AddContent(81, "\n        ");
            builder.OpenElement(82, "button");
            builder.AddAttribute(83, "class", "blue");
            builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(back));
            builder.AddContent(85, "back");
            builder.CloseElement();
            builder.AddContent(86, "\n    ");
            builder.CloseElement();
            builder.AddContent(87, "\n");
#line 68 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"



}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 75 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\login.cshtml"
 
    [Parameter]
    private String myvalue { get; set; }

    User user;
    Boolean to = true;
    Boolean from = false;
    Boolean info;
    String appname;
    Boolean a;
    User arj;
    String username;


    protected override async Task OnInitAsync()
    {
 
        user = await Http.SendJsonAsync<User>(HttpMethod.Post, "/api/Login/getspeuser", myvalue);
    

    

    }
    public void check()
    {
        UriHelper.NavigateTo($"/check/{myvalue}");
    }

    public void payment()
    {
        UriHelper.NavigateTo($"/makepay/{myvalue}");
    }

    public void start()
    {
        UriHelper.NavigateTo($"/create/{user.username}");

    }

    public void updateinfo()
    {
        info = true;
        to = false;

    }

    public async void back()
    {
        user = await Http.SendJsonAsync<User>(HttpMethod.Post, "/api/Login/getspeuser", myvalue);
        to = true;
        info = false;

    }


    public void createapp()
    {

        UriHelper.NavigateTo($"/createapp/{myvalue}");

    }


    public void changeinfo() {

        UriHelper.NavigateTo($"/addinfo/{myvalue}");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591