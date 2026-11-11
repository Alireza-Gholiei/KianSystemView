using Despro.Blazor.Base.Models;
using Services.Models._AuthDtos.UserRoleDtos;
using Services.Repositories.Interface._IAuth.ISSO;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.SSO;

public class UserRoleService(IHttp http) : IUserRoleService
{
    private readonly string _baseUrl = $"{StaticUrls.SSOUrl}/api/sso/v1/UserRole";

    public async Task<GridData<UserRoleGetGridDto>> GetGrid(BaseGrid grid)
    {
        return await http.GetGridAsync<UserRoleGetGridDto>($"{_baseUrl}", grid);
    }

    public async Task<bool> Delete(long Id)
    {
        return await http.DeleteAsync<bool>($"{_baseUrl}/{Id}");
    }
}