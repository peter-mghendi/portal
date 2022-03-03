using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portal.Client;
using MudBlazor.Services;
using Portal.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(_ => new LocationClient(host: builder.HostEnvironment.BaseAddress));
builder.Services.AddMudServices();

await builder.Build().RunAsync();