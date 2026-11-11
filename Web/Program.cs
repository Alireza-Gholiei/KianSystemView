using Despro.Blazor.Layout;
using Despro.Blazor.Message;
using Despro.Blazor.Modal;
using Despro.Blazor.Table;
using Services;
using Services.Models.Configs;
using Storebook.Service;
using Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddAuthenticationStateSerialization();

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

builder.Services.AddAuthorization();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

app.MapGet("/config", (IConfiguration config) => new FrontendConfig
{
    LoginUrls = new LoginUrls
    {
        RefreshTokenApi = config["LoginUrls:RefreshTokenApi"] ?? "",
        PermissionUrls = config["LoginUrls:PermissionUrls"] ?? "",
        RefreshTokenUrl = config["LoginUrls:RefreshTokenUrl"] ?? ""
    },
    WebServiceUrl = new WebServiceUrl
    {
        DevUrl = config["WebServiceUrl:DevUrl"] ?? "",
        DocUrl = config["WebServiceUrl:DocUrl"] ?? "",
        SSOUrl = config["WebServiceUrl:SSOUrl"] ?? "",
        WfUrl = config["WebServiceUrl:WfUrl"] ?? ""
    }
});

app.Run();