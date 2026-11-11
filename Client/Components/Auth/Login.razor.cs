using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Services.Models._AuthDtos.SSODtos;
using Services.Repositories.Interface._IAuth.ISSO;
using Storebook.Service.AuthorizationServices;

namespace Client.Components.Auth;

public partial class Login : BaseComponent
{
    [Inject] private ISsoService SsoService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;
    [Inject] private AuthenticationStateProvider AuthenticationStateService { get; set; } = null!;

    [SupplyParameterFromQuery(Name = "return-url")]
    private string? ReturnUrl { get; set; }
    private bool ShowLoginPassword { get; set; }
    private bool ShowRegisterPassword { get; set; }
    private bool IsSubmit { get; set; }

    private LoginDto LoginDto { get; set; } = new();

    private bool _navigated;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var authStateProvider = (AuthStateProvider)AuthenticationStateService;
            var user = await authStateProvider.GetAuthenticationStateAsync();
            if (user.User.Identity?.IsAuthenticated == true)
            {
                _navigated = true;
                NavigationManager.NavigateTo(string.IsNullOrEmpty(ReturnUrl) ? "/" : ReturnUrl, replace: true);
            }
        }
    }

    private async Task SubmitLogin()
    {
        try
        {
            IsSubmit = true;

            var token = await SsoService.Login(LoginDto);

            await ((AuthStateProvider)AuthenticationStateService).UpdateAuthState(token.AccessToken, token.RefreshToken, token.ExpireRefreshToken);

            if (string.IsNullOrEmpty(ReturnUrl))
            {
                ToastService.SuccessAlertToast("شما وارد حساب کاربری خود شدید");
                NavigationManager.NavigateTo("/", forceLoad: true);
            }
            else
            {
                NavigationManager.NavigateTo(ReturnUrl.Equals("/Login", StringComparison.OrdinalIgnoreCase)
                    ? "/"
                    : ReturnUrl,
                    forceLoad: true);
            }

            IsSubmit = false;
        }
        catch (Exception e)
        {
            IsSubmit = false;
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    private void TogglePassword(bool isLogin)
    {
        if (isLogin)
            ShowLoginPassword = !ShowLoginPassword;
        else
            ShowRegisterPassword = !ShowRegisterPassword;
    }
}