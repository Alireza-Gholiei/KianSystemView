using Despro.Blazor.Base.Models;
using Services.Models._AuthDtos.RoleDtos;
using Services.Repositories.Interface._IAuth.IRole;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.Role;

public class RoleService(IHttp http) : IRoleService
{
    private readonly string _baseUrl = $"{StaticUrls.SSOUrl}/api/sso/v1/Role";

    public async Task<List<RoleGetByRoleTypeForWorkplace>> GetByRoleTypeForWorkplace()
    {
        return await http.GetAsync<List<RoleGetByRoleTypeForWorkplace>>($"{_baseUrl}/GetByRoleTypeForWorkplace");
    }

    public async Task<bool> Insert(RoleAddDto dto)
    {
        return await http.PostAsync<RoleAddDto, bool>($"{_baseUrl}", dto);
    }

    public async Task<bool> Update(RoleEditDto dto)
    {
        return await http.PutAsync<RoleEditDto, bool>($"{_baseUrl}", dto);
    }

    public async Task<List<RoleGetChildDto>> GetChild(long? Id = null)
    {
        if (Id is null)
        {
            return await http.GetAsync<List<RoleGetChildDto>>($"{_baseUrl}/GetChild");
        }
        return await http.GetAsync<List<RoleGetChildDto>>($"{_baseUrl}/GetChild/{Id}");
    }

    public async Task<GridData<RoleGetGridDto>> GetGrid(BaseGrid grid)
    {
        return await http.GetGridAsync<RoleGetGridDto>($"{_baseUrl}", grid);
    }

    public async Task<RoleGetByIdDto> GetById(long Id)
    {
        return await http.GetAsync<RoleGetByIdDto>($"{_baseUrl}/{Id}");
    }
}