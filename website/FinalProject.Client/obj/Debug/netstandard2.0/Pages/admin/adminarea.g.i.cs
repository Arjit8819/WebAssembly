#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\adminarea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a4758761510e957a5f1e96a4916436d6051e18"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    using FinalProject.Shared;
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/adminarea")]
    public class adminarea : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 51 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\admin\adminarea.cshtml"
 
    int count = 0;
    int name;
    User[] user;
    Boolean arj;

    protected override async Task OnInitAsync()
    {
        user = await Http.GetJsonAsync<User[]>("/api/Login/getuse");
    }

    public async void resolve(String value) {

        arj = await Http.SendJsonAsync<Boolean>(HttpMethod.Post ,"/api/Login/resolvesurvey", value); ;


    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591