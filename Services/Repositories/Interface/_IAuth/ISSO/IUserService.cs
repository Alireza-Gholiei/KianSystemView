using Despro.Blazor.Base.Models;
using Services.Models._AuthDtos.UserDtos;

namespace Services.Repositories.Interface._IAuth.ISSO;

public interface IUserService
{
    Task<UserGetDetailByPhoneDto> GetDetailByPhone(string PhoneNumber);
    Task<bool> AddToRole(UserAddToRoleDto dto);
    Task<GridData<UserGetGridDto>> GetGrid(BaseGrid grid);
}