using AnixProject.Client;
using AnixProject.Client.Services.AnimeServices;
using JikanDotNet;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("AnixProject.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("AnixProject.ServerAPI"));
builder.Services.AddMudServices();
builder.Services.AddSingleton<IJikan, Jikan>().BuildServiceProvider();
builder.Services.AddScoped<IAnimeService, AnimeService>();
await builder.Build().RunAsync();
