#pragma checksum "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "affc4ffd300d561f2faacad02f1c068ef95a8157"
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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/blood/{myvalue}")]
    public class blood : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 5 "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml"
 if (to)
{


#line default
#line hidden
            builder.AddContent(0, "    ");
            builder.AddMarkupContent(1, "<h3>hair</h3>\n");
            builder.AddMarkupContent(2, "    <img src=\"/css/image/Lady.jpeg\">\n");
            builder.AddContent(3, "    ");
            builder.OpenElement(4, "input");
            builder.AddAttribute(5, "type", "text");
            builder.AddAttribute(6, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(word));
            builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => word = __value, word));
            builder.CloseElement();
            builder.AddContent(8, "\n    ");
            builder.OpenElement(9, "button");
            builder.AddAttribute(10, "type", "Submit");
            builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(check));
            builder.AddContent(12, "Check");
            builder.CloseElement();
            builder.AddContent(13, "\n    ");
            builder.OpenElement(14, "div");
            builder.AddContent(15, " Attempts Remaing : ");
            builder.AddContent(16, count);
            builder.CloseElement();
            builder.AddContent(17, "\n");
#line 15 "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml"
}

#line default
#line hidden
#line 16 "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml"
 if (from)
{


#line default
#line hidden
            builder.AddContent(18, "    ");
            builder.AddMarkupContent(19, "<p>Hair sample belongs to the lady.</p>\n");
            builder.AddContent(20, "    ");
            builder.OpenElement(21, "button");
            builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(guess));
            builder.AddContent(23, "Guess");
            builder.CloseElement();
            builder.AddContent(24, "\n");
#line 22 "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml"


}

#line default
#line hidden
#line 25 "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml"
 if (by)
{


#line default
#line hidden
            builder.AddContent(25, "    ");
            builder.AddMarkupContent(26, "<p>\n        Clue tempered Cannot attempt another chance .\n        Guess from remaing clues.\n    </p>\n");
#line 32 "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml"
}

#line default
#line hidden
            builder.OpenElement(27, "div");
            builder.OpenElement(28, "button");
            builder.AddAttribute(29, "type", "Submit");
            builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(back));
            builder.AddContent(31, "Back");
            builder.CloseElement();
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 34 "C:\INFO 6250\Finalproject\game\game2.Client\Game\blood.cshtml"
           

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
