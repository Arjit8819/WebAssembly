#pragma checksum "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0f16aff46563c8c98fd15ad0cc33abff396bff"
// <auto-generated/>
#pragma warning disable 1591
namespace game2.Client.Pages
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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class first : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 7 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
 if (to)
{

#line default
#line hidden
            builder.AddContent(0, "    ");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "body2");
            builder.AddMarkupContent(3, "\n        <br><br>\n        \n        <br><br><br>\n                ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "center container col-sm-6");
            builder.AddMarkupContent(6, "\n                    <img height=\"80\" width=\"80\" src=\"/css/image/nick.jpg\">");
            builder.AddMarkupContent(7, "<h4 style=\"color:white\">\n                        Nick fury called you to\n                        solve a murder case at Avenger Headquater.\n                    </h4>\n                    <br><br>\n                    ");
            builder.OpenElement(8, "input");
            builder.AddAttribute(9, "style", "color:white");
            builder.AddAttribute(10, "type", "text");
            builder.AddAttribute(11, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(name));
            builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => name = __value, name));
            builder.CloseElement();
            builder.AddContent(13, "\n                    ");
            builder.OpenElement(14, "button");
            builder.AddAttribute(15, "class", "btn waves-effect waves-light");
            builder.AddAttribute(16, "type", "Submit");
            builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(Proceed));
            builder.AddContent(18, "Submit");
            builder.CloseElement();
            builder.AddContent(19, "\n                ");
            builder.CloseElement();
            builder.AddContent(20, "\n    ");
            builder.CloseElement();
            builder.AddContent(21, "\n");
#line 23 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
}

#line default
#line hidden
#line 24 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
 if (from)
{

#line default
#line hidden
            builder.AddContent(22, "    ");
            builder.OpenElement(23, "div");
            builder.AddAttribute(24, "class", "body3");
            builder.AddContent(25, "\n        ");
            builder.OpenElement(26, "div");
            builder.AddAttribute(27, "class", "center container col-sm-6");
            builder.AddContent(28, "\n            ");
            builder.AddMarkupContent(29, @"<h5 style=""color : white"">
                <br><br>
                You along with watson are in the cab heading to crime seen.
                Watson tells you that he didn't carry any bag to get clues from Crime scene.
                He asks cab drive to return.....
            </h5>

            ");
            builder.OpenElement(30, "span");
            builder.AddContent(31, "\n                ");
            builder.AddMarkupContent(32, "<h5 style=\"color : white\">\n                    but you asked to continue to go vist the crime scene as the clues might temper by the time they return.\n                </h5>\n                ");
            builder.OpenElement(33, "button");
            builder.AddAttribute(34, "class", "btn waves-effect waves-light");
            builder.AddAttribute(35, "type", "Submit");
            builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(scene));
            builder.AddContent(37, "Go to scene");
            builder.CloseElement();
            builder.AddContent(38, "\n            ");
            builder.CloseElement();
            builder.AddContent(39, "\n            ");
            builder.OpenElement(40, "span");
            builder.AddContent(41, "\n                ");
            builder.AddMarkupContent(42, "<h5 style=\"color : white\"> Go back to 221B Baker Street and take a bag.</h5>\n                ");
            builder.OpenElement(43, "button");
            builder.AddAttribute(44, "class", "btn waves-effect waves-light");
            builder.AddAttribute(45, "type", "Submit");
            builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(home));
            builder.AddContent(47, "Go to Home");
            builder.CloseElement();
            builder.AddContent(48, "\n            ");
            builder.CloseElement();
            builder.AddContent(49, "\n        ");
            builder.CloseElement();
            builder.AddContent(50, "\n    ");
            builder.CloseElement();
            builder.AddContent(51, "\n");
#line 47 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
}

#line default
#line hidden
#line 48 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
 if (home1)
{
 

#line default
#line hidden
            builder.AddContent(52, "    ");
            builder.OpenElement(53, "div");
            builder.AddAttribute(54, "class", "body11");
            builder.AddContent(55, "\n    ");
            builder.AddMarkupContent(56, "<p>You have reached home but now you are an hour late.Cops might have tempered the clues.\n    So the case is now useless to solve.</p>\n    ");
            builder.OpenElement(57, "button");
            builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(backnick));
            builder.AddAttribute(59, "type", "submit");
            builder.AddContent(60, "Back");
            builder.CloseElement();
            builder.AddContent(61, "\n   ");
            builder.CloseElement();
            builder.AddContent(62, "\n");
#line 56 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
    // <button type="submit" onclick="@crime">Go to crime scene</button>
}

#line default
#line hidden
#line 58 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
 if (by)
{

#line default
#line hidden
            builder.AddContent(63, "    ");
            builder.OpenElement(64, "div");
            builder.AddAttribute(65, "class", "body4");
            builder.AddMarkupContent(66, "\n        <br><br><br>\n        ");
            builder.OpenElement(67, "div");
            builder.AddAttribute(68, "class", "center container col-sm-6");
            builder.AddContent(69, "\n            ");
            builder.AddMarkupContent(70, "<h5 style=\"color:white\">\n                You have reached the crime scene. You are here at drawing room.\n                But Now you can only pick up three clues with you choose wisely.\n            </h5>\n            ");
            builder.OpenElement(71, "span");
            builder.AddContent(72, "\n                ");
            builder.AddMarkupContent(73, "<h5 style=\"color:white\">\n                    You see two glasses would you like to pick them as clues or move forward.\n                </h5>\n                ");
            builder.OpenElement(74, "button");
            builder.AddAttribute(75, "class", "btn waves-effect waves-light");
            builder.AddAttribute(76, "type", "Submit");
            builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(getglass));
            builder.AddContent(78, "PickUp glasses");
            builder.CloseElement();
            builder.AddContent(79, "\n                ");
            builder.OpenElement(80, "button");
            builder.AddAttribute(81, "class", "btn waves-effect waves-light");
            builder.AddAttribute(82, "type", "Submit");
            builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(move));
            builder.AddContent(84, "Move Forward");
            builder.CloseElement();
            builder.AddContent(85, "\n                ");
            builder.OpenElement(86, "h5");
            builder.AddAttribute(87, "style", "color:red");
            builder.AddContent(88, glassString);
            builder.CloseElement();
            builder.AddContent(89, "\n            ");
            builder.CloseElement();
            builder.AddContent(90, "\n        ");
            builder.CloseElement();
            builder.AddContent(91, "\n    ");
            builder.CloseElement();
            builder.AddContent(92, "\n");
#line 77 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 80 "C:\INFO 6250\Finalproject\game\game2.Client\Pages\first.cshtml"
           

    String name;
    Boolean test;
    Boolean to = true;
    Boolean from;
    Boolean by;
    Boolean home1;
    int glasscount = 0;
    String glassString;

    public void move()
    {

        UriHelper.NavigateTo($"/main/{name}");
    }

    public async void Proceed()
    {
        to = false;
        from = true;

        String body = (name + ":name");
        test = await Http.SendJsonAsync<Boolean>(HttpMethod.Post, "/api/Game/SignUp", name);

    }

    public async void getglass()
    {
        if (glasscount < 1)
        {
            glasscount++;
            String body = (name + ":glass");
            await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/putclue", body);

        }
        else {
            glassString = "Glass already taken";
        }
    }

    public void home()
    {
        from = false;
        home1 = true;

    }
    public void backnick()
    {
        home1 = false;
        to = true;

    }
    public void scene()
    {
        from = false;
        by = true;

    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
