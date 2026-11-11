using Services.Models._AuthDtos.SSODtos;
using Services.Models._AuthDtos.UserDtos;

namespace Services.Repositories.Interface._IAuth.ISSO;

public interface ISsoService
{
    Task<LoginResultDto> Login(LoginDto model);
    Task<LoginResultDto> Register(RegisterDto model);
    Task<UserRequestTotpDto> RequestTotp(ForgotPasswordDto model);
    Task<bool> ForgotPassword(ForgotPasswordDto model);
    Task<bool> VerifyTotpForgotPassword(ForgotPasswordDto model);
    Task<List<UserRoleDto>> GetUserRoles();
    Task<bool> IsLogin();
}