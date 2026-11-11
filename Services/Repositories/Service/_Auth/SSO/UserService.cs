using Despro.Blazor.Base.Models;
using Services.Models._AuthDtos.UserDtos;
using Services.Repositories.Interface._IAuth.ISSO;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.SSO;

public class UserService(IHttp http) : IUserService
{
    private readonly string _baseUrl = $"{StaticUrls.SSOUrl}/api/sso/v1/User";

    public async Task<UserGetDetailByPhoneDto> GetDetailByPhone(string PhoneNumber)
    {
        return await http.GetAsync<UserGetDetailByPhoneDto>($"{_baseUrl}/GetDetailByPhone/{PhoneNumber}");
    }

    public async Task<bool> AddToRole(UserAddToRoleDto dto)
    {
        return await http.PostAsync<UserAddToRoleDto, bool>($"{_baseUrl}/AddToRole", dto);
    }

    public async Task<GridData<UserGetGridDto>> GetGrid(BaseGrid grid)
    {
        return await http.GetGridAsync<UserGetGridDto>($"{_baseUrl}", grid);
    }
}