using Despro.Blazor.Base.Services;
using Microsoft.AspNetCore.Components;

namespace Client.Layout;

public partial class MainLayout : LayoutComponentBase, IDisposable
{
    [Inject] private AppService AppService { get; set; }

    protected override void OnInitialized()
    {
        AppService.OnSettingsUpdated += SettingsUpdated;
    }

    private void SettingsUpdated()
    {
        InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        AppService.OnSettingsUpdated -= SettingsUpdated;
    }
}