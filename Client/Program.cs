using Despro.Blazor.Layout;
using Despro.Blazor.Message;
using Despro.Blazor.Modal;
using Despro.Blazor.Table;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Services;
using Storebook.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddDesproBlazorLayout(true)
    .AddDesproBlazorMessage(true)
    .AddDesproBlazorModal(true)
    .AddDesproBlazorTable(true)
    .AddStoreBookService(true)
    .DiService();

StaticUrls.Init(builder.Configuration["WebServiceUrl:DevUrl"],
    builder.Configuration["WebServiceUrl:SSOUrl"],
    builder.Configuration["WebServiceUrl:DocUrl"],
    builder.Configuration["WebServiceUrl:WfUrl"]);

builder.Services.AddAuthenticationStateDeserialization();

await builder.Build().RunAsync();