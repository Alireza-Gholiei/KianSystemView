using Despro.Blazor.Base.Models;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.UserRoleDtos;
using Services.Repositories.Interface._IAuth.ISSO;

namespace Client.Components.Auth.UserRole;

public partial class UserRoleBind : BaseComponent
{
    [Inject] private IModalService ModalService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;
    [Inject] private IUserRoleService UserRoleService { get; set; } = null!;

    private GridData<UserRoleGetGridDto> _gridData { get; set; } = new GridData<UserRoleGetGridDto>();
    private BaseGrid _baseGrid = new BaseGrid();

    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _baseGrid = grid;

            var model = await UserRoleService.GetGrid(grid);

            _gridData = model;
        }
        catch (Exception e)
        {
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    public async Task Delete(UserRoleGetGridDto mode)
    {
        var confirmAlert = await ToastService.ConfirmAlert($"از حذف نقش {mode.RoleName} از کاربر {mode.UserFullName} اطمینان دارید");
        if (confirmAlert)
        {
            var result = await UserRoleService.Delete(mode.Id);
            if (result)
            {
                await OnBind(_baseGrid);
            }
        }
    }
}