using Despro.Blazor.Base.Models;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.UserDtos;
using Services.Repositories.Interface._IAuth.ISSO;

namespace Client.Components.Auth.User;

public partial class UserBind : BaseComponent
{
    [Inject] private IModalService ModalService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;
    [Inject] private IUserService UserService { get; set; } = null!;

    private GridData<UserGetGridDto> _gridData { get; set; } = new GridData<UserGetGridDto>();
    private BaseGrid _baseGrid = new BaseGrid();

    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _baseGrid = grid;

            var model = await UserService.GetGrid(grid);

            _gridData = model;
        }
        catch (Exception e)
        {
            ToastService.ErrorAlertToast(e.Message);
        }
    }
}