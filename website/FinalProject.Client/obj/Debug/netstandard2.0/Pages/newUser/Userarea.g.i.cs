#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\newUser\Userarea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c15bd5c5928102c6d40b293b6406c307cec541a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinalProject.Client.Pages.newUser
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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/userarea/{myvalue}")]
    public class Userarea : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 64 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\newUser\Userarea.cshtml"
 
    [Parameter]
    private String myvalue { get; set; }

    User[] user;
    Boolean test;
    Viewer viewer;
    Boolean to = true;
    Boolean from;

    protected override async Task OnInitAsync()
    {
        // viewer = await Http.SendJsonAsync<Viewer>(HttpMethod.Post, "/api/NewUser/getspeuser", myvalue);
        user = await Http.GetJsonAsync<User[]>("/api/Login/getuse");
    }

    public async void getsurvey()
    {
        to = false;
        from = true;

        String way = viewer.email;

        user = await Http.SendJsonAsync<User[]>(HttpMethod.Post, "/api/Login/getsurveyuser", way);
    }

    public void resolve(String myvalue)
    {

        UriHelper.NavigateTo($"/viewsurvey/{myvalue}");
    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
