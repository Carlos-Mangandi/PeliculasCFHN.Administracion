using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Peliculas.AdministracionBlazor;
using Peliculas.AdministracionBlazor.Auth;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7047/api/") });

builder.Services.AddMudServices();

builder.Services.AddScoped<UserAuth>();
IServiceCollection serviceCollection = builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
