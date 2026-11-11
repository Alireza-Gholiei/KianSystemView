using Services.Models._AuthDtos.SSODtos;
using Services.Models._AuthDtos.UserDtos;
using Services.Repositories.Interface._IAuth.ISSO;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.SSO;

public class SsoService(IHttp http) : ISsoService
{
    public async Task<LoginResultDto> Login(LoginDto model)
    {
        return await http.PostAsync<LoginDto, LoginResultDto>($"{StaticUrls.SSOUrl}/Login", model);
    }

    public async Task<UserRequestTotpDto> RequestTotp(ForgotPasswordDto model)
    {
        return await http.PostAsync<ForgotPasswordDto, UserRequestTotpDto>($"{StaticUrls.SSOUrl}/RequestTotp", model);
    }

    public async Task<bool> ForgotPassword(ForgotPasswordDto model)
    {
        return await http.PostAsync<ForgotPasswordDto, bool>($"{StaticUrls.SSOUrl}/ForgotPassword", model);
    }

    public async Task<bool> VerifyTotpForgotPassword(ForgotPasswordDto model)
    {
        return await http.PostAsync<ForgotPasswordDto, bool>($"{StaticUrls.SSOUrl}/VerifyTotpForgotPassword", model);
    }

    public async Task<LoginResultDto> Register(RegisterDto model)
    {
        return await http.PostAsync<RegisterDto, LoginResultDto>($"{StaticUrls.SSOUrl}/Register", model);
    }

    public async Task<List<UserRoleDto>> GetUserRoles()
    {
        return await http.GetAsync<List<UserRoleDto>>($"{StaticUrls.SSOUrl}/v1/UserRole/GetUserRoles");
    }

    public async Task<bool> IsLogin()
    {
        return await http.GetAsync<bool>($"{StaticUrls.SSOUrl}/IsLogin");
    }
}