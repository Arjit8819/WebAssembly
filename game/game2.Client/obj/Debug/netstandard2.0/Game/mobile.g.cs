#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c808390be91268933742a2cac8c5cd64a9a3c52"
// <auto-generated/>
#pragma warning disable 1591
namespace game2.Client.Game
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
    using game2.Client;
    using game2.Shared;
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/mobile/{myvalue}")]
    public class mobile : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 7 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml"
 if (to)
{

#line default
#line hidden
            builder.AddContent(0, "    ");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "body4");
            builder.AddContent(3, "\n    ");
            builder.AddMarkupContent(4, "<p>To unlock the phone write the pin.</p>\n    <img height=\"450\" width=\"600\" src=\"/css/image/WhatsApp Image 2018-12-12 at 4.55.27 PM.jpeg\">\n\n    ");
            builder.OpenElement(5, "input");
            builder.AddAttribute(6, "type", "text");
            builder.AddAttribute(7, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(word));
            builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => word = __value, word));
            builder.CloseElement();
            builder.AddContent(9, "\n    ");
            builder.OpenElement(10, "button");
            builder.AddAttribute(11, "type", "Submit");
            builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(check));
            builder.AddContent(13, "Check");
            builder.CloseElement();
            builder.AddContent(14, "\n    ");
            builder.OpenElement(15, "div");
            builder.AddContent(16, " Attempts Remaing : ");
            builder.AddContent(17, count);
            builder.CloseElement();
            builder.AddContent(18, "\n        ");
            builder.CloseElement();
            builder.AddContent(19, "\n");
#line 17 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml"
}

#line default
#line hidden
#line 18 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml"
 if (from)
{


#line default
#line hidden
            builder.AddContent(20, "    ");
            builder.AddMarkupContent(21, "<p>Hair sample belongs to the lady.</p>\n");
            builder.AddContent(22, "    ");
            builder.OpenElement(23, "button");
            builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(guess));
            builder.AddContent(25, "Guess");
            builder.CloseElement();
            builder.AddContent(26, "\n");
#line 24 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml"


}

#line default
#line hidden
#line 27 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml"
 if (by)
{


#line default
#line hidden
            builder.AddContent(27, "    ");
            builder.AddMarkupContent(28, "<p>\n        Clue tempered Cannot attempt another chance .\n        Guess from remaing clues.\n    </p>\n");
#line 34 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml"
}

#line default
#line hidden
            builder.OpenElement(29, "div");
            builder.OpenElement(30, "button");
            builder.AddAttribute(31, "type", "Submit");
            builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(back));
            builder.AddContent(33, "Back");
            builder.CloseElement();
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 36 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\mobile.cshtml"
           

    [Parameter]
    private String myvalue { get; set; }

    String word;
    Boolean to = true;
    Boolean from;
    Boolean by;
    int count = 3;
    public void check()
    {

        if (word == "lady")
        {
            to = false;
            from = true;

        }
        else
        {

            if (count <= 1)
            {
                to = false;
                by = true;
            }
            else
            {
                count = count - 1;
            }
        }


    }

    public void back()
    {

        UriHelper.NavigateTo($"/choose/{myvalue}");
    }

    public void guess()
    {

        UriHelper.NavigateTo($"/guess/{myvalue}");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
