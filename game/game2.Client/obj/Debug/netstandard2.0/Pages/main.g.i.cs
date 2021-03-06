#pragma checksum "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Pages\main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5b8398d5684c814c305cab49a8fd5d285f72d7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/main/{myvalue}")]
    public class main : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 137 "C:\GitRepository\Webassembly\Game\WebAssembly\game\game2.Client\Pages\main.cshtml"
                       
                String clues;
                String finalclue;
                Boolean test;
                Boolean first = true;
                Boolean second;
                Boolean third;
                Boolean fourth;
                Boolean kitchen;
                Boolean backyard;
                Boolean lab;
                String gunString;
                int guncount;
                String hairString;
                int haircount;
                String phoneString;
                int phonecount;
                String carString;
                int carcount;
                Game game;


                [Parameter]
                private String myvalue { get; set; }

                protected override async Task OnInitAsync()
                {
                    game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);

                }

                public async void getphone()
                {
                    phonecount++;
                    String body = (myvalue + ":Mobile");
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/putclue", body);

                    game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);

                }

                public void backhome() {

                    kitchen = false;
                    fourth = true;

                }

                public async void getHair()
                {
                    if (haircount < 1)
                    {
                        haircount++;
                        String body = (myvalue + ":Hair");
                        await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/putclue", body);

                        game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);

                    }
                    else
                    {
                        hairString = "Hair already taken";
                    }
                }
                public async void getCartridge()
                {
                    if (carcount < 1)
                    {
                        carcount++;
                        String body = (myvalue + ":Cartridge");
                        await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/putclue", body);

                        game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);
                    }
                    else
                    {
                        carString = "Cartridge already taken";
                    }
                }

                public async void getgun()
                {
                    if (guncount < 1)
                    {
                        guncount++;
                        String body = (myvalue + ":gun");
                        await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/putclue", body);
                        game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);
                    }
                    else
                    {
                        gunString = "gun already taken";
                    }
                }

                public void proceed()
                {
                    kitchen = false;
                    backyard = false;

                    lab = true;

                }
                public void labo()
                {

                    UriHelper.NavigateTo($"/choose/{myvalue}");
                }
                public void checkroom()
                {
                    second = false;
                    third = true;

                }
                public void gokitchen()
                {
                    fourth = false;
                    kitchen = true;

                }
                public void gobackyard()
                {
                    fourth = false;
                    backyard = true;

                }
                public void forward()
                {
                    first = false;
                    second = true;

                }
                public void fourthcall()
                {

                    third = false;
                    fourth = true;
                }
                public async void continu()
                {
                    string str = finalclue.Substring(1);
                    string body = (myvalue + ":" + str);
                    Console.WriteLine(body);
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/putclue", body);
                    UriHelper.NavigateTo($"/choose/{myvalue}");
                }
                public async void drop1()
                {
                    String body = (myvalue + ":1");
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/deleteclue", body);
                    game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);

                }
                public async void drop2()
                {
                    String body = (myvalue + ":2");
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/deleteclue", body);
                    game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);

                }
                public async void drop3()
                {
                    String body = (myvalue + ":3");
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/Game/deleteclue", body);
                    game = await Http.SendJsonAsync<Game>(HttpMethod.Post, "/api/Game/getclue", myvalue);

                }
            

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
