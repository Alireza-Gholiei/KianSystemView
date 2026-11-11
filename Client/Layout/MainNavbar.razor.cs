using Client.Components._Shared;
using Despro.Blazor.Base.BaseGenerals;
using Despro.Blazor.Base.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Services.Repositories.Interface._IAuth.ISSO;
using Storebook.Service.AuthorizationServices;

namespace Client.Layout;

public partial class MainNavbar : BaseComponent, IDisposable
{
    [Inject] private AppService AppService { get; set; } = null!;
    [Inject] private ISsoService UserService { get; set; } = null!;
    [Inject] private IModalService ModalService { get; set; } = null!;
    [Inject] private AuthenticationStateProvider StateProvider { get; set; } = null!;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;

    private NavbarDirection direction { get; set; }
    private string UserName { get; set; } = "";
    private long RoleId { get; set; } = 0;
    private string RoleName { get; set; } = "";

    protected override void OnInitialized()
    {
        AppService.OnSettingsUpdated += SettingsUpdated;
        _ = LoadAsync();
    }

    private async Task LoadAsync()
    {
        direction = AppService.Settings.NavbarDirection switch
        {
            NavbarDirection.Horizontal => NavbarDirection.Vertical,
            NavbarDirection.Vertical => NavbarDirection.Horizontal,
            _ => direction
        };

        var stateProvider = (AuthStateProvider)StateProvider;

        var claims = await stateProvider.GetAuthenticationStateAsync();

        if (claims.User.Claims.Any())
        {
            var userDetail = await stateProvider.GetUserDetailFromStorage();
            UserName = userDetail.FullName;
            RoleId = await stateProvider.GetRole();
            var userRoles = await UserService.GetUserRoles();
            RoleName = userRoles.FirstOrDefault(x => x.RoleId == RoleId)?.RoleName!;
        }

        StateHasChanged();
    }

    private void SettingsUpdated()
    {
        InvokeAsync(StateHasChanged);
    }

    private async Task Logout()
    {
        await ((AuthStateProvider)StateProvider).LogoutAsync();
        NavigationManager.Refresh(true);
    }

    private async Task RoleSelectFn()
    {
        var roleSelect = new RenderComponent<RoleSelect>();

        await ModalService.ShowAsync("انتخاب نقش", roleSelect);

        NavigationManager.Refresh(true);
    }

    void IDisposable.Dispose() => AppService.OnSettingsUpdated -= SettingsUpdated;
}