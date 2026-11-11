using Despro.Blazor.Base.Models;
using Services.Models._AuthDtos.RoleDtos;

namespace Services.Repositories.Interface._IAuth.IRole;

public interface IRoleService
{
    Task<List<RoleGetByRoleTypeForWorkplace>> GetByRoleTypeForWorkplace();
    Task<bool> Insert(RoleAddDto dto);
    Task<bool> Update(RoleEditDto dto);
    Task<List<RoleGetChildDto>> GetChild(long? Id = null);
    Task<GridData<RoleGetGridDto>> GetGrid(BaseGrid grid);
    Task<RoleGetByIdDto> GetById(long Id);
}