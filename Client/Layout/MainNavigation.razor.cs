using Despro.Blazor.Base.Services;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.FormDtos;
using Services.Repositories.Interface._IAuth;

namespace Client.Layout;

public partial class MainNavigation : BaseComponent, IDisposable
{
    [Inject] private IFormService FormService { get; set; } = null!;
    [Inject] private AppService AppService { get; set; } = null!;

    private List<FormGetMenuDto> Menus { get; set; } = [];

    private void SettingsUpdated()
    {
        InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        AppService.OnSettingsUpdated -= SettingsUpdated;
    }

    protected override async Task OnInitializedAsync()
    {
        AppService.OnSettingsUpdated += SettingsUpdated;
        Menus = await FormService.GetMenu();
    }
}