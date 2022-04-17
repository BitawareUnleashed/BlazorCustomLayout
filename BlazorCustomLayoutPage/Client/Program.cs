using BlazorCustomLayoutPage.Client;
using BlazorCustomLayoutPage.Client.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Read section in DI
builder.Services.Configure<StartupLayout>(options => builder.Configuration.GetSection("StartupLayout").Bind(options));
builder.Services.AddScoped<IUserLayout, UserLayout>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
