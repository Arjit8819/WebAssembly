#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b058401e2db4660345f9b1d7604af26f078a33ad"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/index")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 32 "C:\GitRepository\Webassembly\Game\WebAssembly\website\FinalProject.Client\Pages\Index.cshtml"
 
string name;
string pass;
string namecheck;
string passcheck;
string wrongpassword = "";
User use;

public async void CheckUse()
{
    String body = (namecheck + ":" + passcheck);

    use = await Http.SendJsonAsync<User>(HttpMethod.Post, "/api/Login/Signin", body);

    if (!use.username.Equals(""))
    {
        UriHelper.NavigateTo($"/login/{use.username}");
    }   
    else
    {
        wrongpassword = "Wrong credentials";
        namecheck = "";
        passcheck = "";


    }

}

public void Adduser()
{
    String body = (name + ":" + pass);

    Http.SendJsonAsync(HttpMethod.Post, "/api/Login/Signup", body);
    name = "";
    pass = "";
}


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591