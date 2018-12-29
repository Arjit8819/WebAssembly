#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7481a2fc00bc1d45210e8f34371a0e344a02f3ad"
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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/makepay/{myvalue}")]
    public class makePayment : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "body1");
            builder.AddContent(2, "\n");
#line 8 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
 if (user == null)
{

#line default
#line hidden
            builder.AddContent(3, "    ");
            builder.AddMarkupContent(4, "<div class=\"progress\">\n        <div class=\"indeterminate\"></div>\n    </div>\n");
#line 13 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
}
else
{


    

#line default
#line hidden
#line 18 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
     if (to)
    {

#line default
#line hidden
            builder.AddMarkupContent(5, "        <br><br><br><br><br><br><br><br><br>\n        ");
            builder.OpenElement(6, "center");
            builder.AddContent(7, "\n        ");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "class", "col-sm-6");
            builder.AddContent(10, "\n        ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class", "container center");
            builder.AddContent(13, "\n            ");
            builder.OpenElement(14, "input");
            builder.AddAttribute(15, "style", "color:white");
            builder.AddAttribute(16, "type", "text");
            builder.AddAttribute(17, "placeholder", "Add the amount of money");
            builder.AddAttribute(18, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(money));
            builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => money = __value, money));
            builder.CloseElement();
            builder.AddContent(20, "\n            ");
            builder.OpenElement(21, "button");
            builder.AddAttribute(22, "class", "btn waves-effect blue");
            builder.AddAttribute(23, "type", "submit");
            builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(sendbypaypal));
            builder.AddContent(25, "Paypal payment");
            builder.CloseElement();
            builder.AddContent(26, "\n            ");
            builder.OpenElement(27, "button");
            builder.AddAttribute(28, "class", "btn waves-effect blue");
            builder.AddAttribute(29, "type", "submit");
            builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(sendmoney));
            builder.AddContent(31, "Credit/Debit card");
            builder.CloseElement();
            builder.AddContent(32, "\n        ");
            builder.CloseElement();
            builder.AddContent(33, "\n            ");
            builder.CloseElement();
            builder.AddContent(34, "\n            ");
            builder.CloseElement();
            builder.AddContent(35, "\n");
#line 30 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
    }

#line default
#line hidden
#line 31 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
     if (from)
    {


#line default
#line hidden
            builder.AddContent(36, "        ");
            builder.OpenElement(37, "h3");
            builder.AddAttribute(38, "style", "color:white");
            builder.AddContent(39, " Confirm the payment for : ");
            builder.AddContent(40, money);
            builder.CloseElement();
            builder.AddContent(41, "\n        ");
            builder.OpenElement(42, "form");
            builder.AddAttribute(43, "class", "paypalform");
            builder.AddAttribute(44, "action", "https://www.sandbox.paypal.com/cgi-bin/webscr");
            builder.AddAttribute(45, "method", "post");
            builder.AddMarkupContent(46, "\n            <input type=\"hidden\" name=\"cmd\" value=\"_cart\">\n            <input type=\"hidden\" name=\"upload\" value=\"1\">\n            <input type=\"hidden\" name=\"business\" value=\"arjit9039-facilitator@gmail.com\">\n");
#line 39 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
             foreach (var use in user)
            {

#line default
#line hidden
            builder.AddContent(47, "                ");
            builder.OpenElement(48, "input");
            builder.AddAttribute(49, "type", "hidden");
            builder.AddAttribute(50, "name", "item_name_" + (count));
            builder.AddAttribute(51, "value", use.username);
            builder.CloseElement();
            builder.AddContent(52, "\n                ");
            builder.OpenElement(53, "input");
            builder.AddAttribute(54, "type", "hidden");
            builder.AddAttribute(55, "name", "amount_" + (count));
            builder.AddAttribute(56, "value", use.money);
            builder.CloseElement();
            builder.AddContent(57, "\n");
#line 43 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
                count++;
            }

#line default
#line hidden
            builder.AddMarkupContent(58, "\n            <input type=\"hidden\" name=\"currency_code\" value=\"USD\">\n            <input type=\"image\" src=\"http://www.paypal.com/en_US/i/btn/x-click-but01.gif\" name=\"submit\" alt=\"Make payments with PayPal - it\'s fast, free and secure!\">\n        ");
            builder.CloseElement();
            builder.AddContent(59, "\n");
#line 49 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
    }

#line default
#line hidden
#line 50 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
     if (by)
    {


#line default
#line hidden
            builder.AddMarkupContent(60, @"        <input style=""color:white"" type=""text"" placeholder=""Card UserName"">
        <input style=""color:white"" type=""text"" placeholder=""Card number"">
        <input style=""color:white"" type=""text"" placeholder=""Last valid day mm/yy"">
        <input style=""color:white"" type=""text"" placeholder=""CVV"">
        ");
            builder.OpenElement(61, "button");
            builder.AddAttribute(62, "class", "btn waves-effect waves-light");
            builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(pay));
            builder.AddContent(64, "Paymoney");
            builder.CloseElement();
            builder.AddContent(65, "\n");
#line 58 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"


    }

#line default
#line hidden
            builder.AddContent(66, "    ");
            builder.OpenElement(67, "button");
            builder.AddAttribute(68, "class", "btn waves-effect waves-light");
            builder.AddAttribute(69, "type", "submit");
            builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(back));
            builder.AddContent(71, "Back");
            builder.CloseElement();
            builder.AddContent(72, "\n");
#line 62 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
}

#line default
#line hidden
            builder.AddContent(73, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 67 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\makePayment.cshtml"
 
    int count = 1;
    User[] user;
    String money;
    Boolean to = true;
    Boolean from;
    Boolean by;

    [Parameter]
    private String myvalue { get; set; }

    protected override async Task OnInitAsync()
    {
        user = await Http.GetJsonAsync<User[]>("/api/Login/getuse");
    }

    Boolean a;



    public async void sendbypaypal()
    {
        to = false;
        from = true;
        string body = (myvalue + ":" + money);

        a = await Http.SendJsonAsync<Boolean>(HttpMethod.Post, "/api/Login/sendmoney", body);


    }
    public async void pay() {

        string body = (myvalue + ":" + money);

        a = await Http.SendJsonAsync<Boolean>(HttpMethod.Post, "/api/Login/sendmoney", body);

    }

    public void sendmoney()
    {
        to = false;
        by = true;

    }
    public void back()
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