#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createsurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee22b018a19aee21d4979839422eb50519bb784a"
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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/create/{myvalue}")]
    public class createsurvey : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "body1");
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "center");
            builder.AddMarkupContent(4, "\n    <br><br>\n    ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "col-sm-6");
            builder.AddContent(7, "\n\n        ");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "class", "container center");
            builder.AddContent(10, "\n            ");
            builder.AddMarkupContent(11, "<h5 style=\"color:white\">Create survey</h5>\n\n\n            ");
            builder.OpenElement(12, "ul");
            builder.AddContent(13, "\n");
#line 16 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createsurvey.cshtml"
                 foreach (var todo in todos)
                {

#line default
#line hidden
            builder.AddContent(14, "                    ");
            builder.OpenElement(15, "ul");
            builder.AddAttribute(16, "style", "color : white");
            builder.AddContent(17, todo.Title);
            builder.CloseElement();
            builder.AddContent(18, "\n");
#line 19 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createsurvey.cshtml"
                }

#line default
#line hidden
            builder.AddContent(19, "            ");
            builder.CloseElement();
            builder.AddContent(20, "\n\n\n            ");
            builder.OpenElement(21, "input");
            builder.AddAttribute(22, "style", "color:white");
            builder.AddAttribute(23, "placeholder", "Something todo");
            builder.AddAttribute(24, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(newTodo));
            builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => newTodo = __value, newTodo));
            builder.CloseElement();
            builder.AddContent(26, "\n            ");
            builder.OpenElement(27, "button");
            builder.AddAttribute(28, "class", "btn waves-effect waves-light");
            builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(AddTodo));
            builder.AddContent(30, "Add");
            builder.CloseElement();
            builder.AddContent(31, "\n \n            \n        ");
            builder.CloseElement();
            builder.AddContent(32, "\n        ");
            builder.OpenElement(33, "div");
            builder.AddAttribute(34, "class", "container");
            builder.AddContent(35, "\n\n            ");
            builder.AddMarkupContent(36, "<h5 style=\"color:white\">Put your game link here</h5>\n\n            ");
            builder.OpenElement(37, "ul");
            builder.AddContent(38, "\n");
#line 33 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createsurvey.cshtml"
                 foreach (var todo in Emails)
                {

#line default
#line hidden
            builder.AddContent(39, "                    ");
            builder.OpenElement(40, "ul");
            builder.AddAttribute(41, "style", "color : blue");
            builder.AddContent(42, todo.Title);
            builder.CloseElement();
            builder.AddContent(43, "\n");
#line 36 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createsurvey.cshtml"

                }

#line default
#line hidden
            builder.AddContent(44, "            ");
            builder.CloseElement();
            builder.AddContent(45, "\n\n            ");
            builder.OpenElement(46, "input");
            builder.AddAttribute(47, "style", "color:white");
            builder.AddAttribute(48, "placeholder", "Something todo");
            builder.AddAttribute(49, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(newemail));
            builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => newemail = __value, newemail));
            builder.CloseElement();
            builder.AddMarkupContent(51, "\n            <br>\n            ");
            builder.OpenElement(52, "button");
            builder.AddAttribute(53, "class", "btn waves-effect waves-light");
            builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(Addemail));
            builder.AddContent(55, "Add todo");
            builder.CloseElement();
            builder.AddMarkupContent(56, "\n            <br>\n            <br>\n            ");
            builder.OpenElement(57, "button");
            builder.AddAttribute(58, "class", "btn waves-effect waves-light");
            builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(sendsurvey));
            builder.AddContent(60, "Create survey");
            builder.CloseElement();
            builder.AddContent(61, "\n               \n            ");
            builder.OpenElement(62, "button");
            builder.AddAttribute(63, "class", "btn waves-effect waves-light");
            builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(Sendingsurvey));
            builder.AddContent(65, "Send Survey");
            builder.CloseElement();
            builder.AddMarkupContent(66, "\n            <br>\n            <br>\n            ");
            builder.OpenElement(67, "button");
            builder.AddAttribute(68, "class", "btn waves-effect waves-light");
            builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(back));
            builder.AddContent(70, "Back");
            builder.CloseElement();
            builder.AddContent(71, "\n\n        ");
            builder.CloseElement();
            builder.AddContent(72, "\n\n    ");
            builder.CloseElement();
            builder.AddContent(73, "\n");
            builder.CloseElement();
            builder.AddContent(74, "\n    ");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 58 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\customer\createsurvey.cshtml"
            

    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
    IList<TodoItem> todos = new List<TodoItem>();

    public class EmailItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
    IList<EmailItem> Emails = new List<EmailItem>();

    string newTodo;
    string newemail;
    string surveys;
    string emails;
    int count;
    User user;
    Boolean test;

    [Parameter]
    private String myvalue { get; set; }

    Boolean status;

    void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            surveys = (surveys + "," + newTodo);
            newTodo = string.Empty;

        }
    }

    void Addemail()
    {
        if (!string.IsNullOrWhiteSpace(newemail))
        {
            Emails.Add(new EmailItem { Title = newemail });
            emails = (emails + "," + newemail);
            Console.WriteLine(emails);
            newemail = string.Empty;

        }
    }

    public async void sendsurvey()
    {
        string str = surveys.Substring(1);
        string str1 = emails.Substring(1);

        // string body = (myvalue + ":" + str+":"+str1);
        string body = (myvalue + ":" + str+":"+str1);
        Console.WriteLine(body);
        status = await Http.SendJsonAsync<Boolean>(HttpMethod.Post, "/api/Login/sendsurvey", body);

    }

    public void back()
    {

        UriHelper.NavigateTo($"/login/{myvalue}");
    }
    public async void Sendingsurvey() {

        count = 5;
        String way = (myvalue + ":" + count);


        test = await Http.SendJsonAsync<Boolean>(HttpMethod.Post, "/api/Login/decreasemoney", way);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591