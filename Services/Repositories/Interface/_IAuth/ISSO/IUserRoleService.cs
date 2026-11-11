using Despro.Blazor.Base.Models;
using Services.Models._AuthDtos.UserRoleDtos;

namespace Services.Repositories.Interface._IAuth.ISSO;

public interface IUserRoleService
{
    Task<GridData<UserRoleGetGridDto>> GetGrid(BaseGrid grid);
    Task<bool> Delete(long Id);
}