#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\bullet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284242a9b5a032f844435e34dd6f1bbf106fb513"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/bullet/{myvalue}")]
    public class bullet : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 34 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Game\bullet.cshtml"
           

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
