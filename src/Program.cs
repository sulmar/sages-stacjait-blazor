using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StacjaIT.BlazorApp;
using StacjaIT.BlazorApp.Abstractions;
using StacjaIT.BlazorApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// dotnet add package Microsoft.Extensions.Http
builder.Services.AddHttpClient<IUserService, JsonPlaceHolderUserService>(sp => sp.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"));

await builder.Build().RunAsync();
