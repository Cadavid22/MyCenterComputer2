using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyCenter.Frontend;
using MyCenter.Frontend.Repositories;
using MyCenterComputer.Frontend;
using MyCenterComputer.Frontend.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7122/") });
builder.Services.AddScoped<IRepository,Repository>();
builder.Services.AddSweetAlert2();


await builder.Build().RunAsync();
