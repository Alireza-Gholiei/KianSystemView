using Despro.Blazor.Base.Models;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.RoleDtos;
using Services.Repositories.Interface._IAuth.IRole;

namespace Client.Components.Auth.Role;

public partial class RoleBind : BaseComponent
{
    [Inject] private IModalService ModalService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;
    [Inject] private IRoleService RoleService { get; set; } = null!;

    private GridData<RoleGetGridDto> GridData { get; set; } = new();
    private BaseGrid _baseGrid = new();

    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _baseGrid = grid;

            var model = await RoleService.GetGrid(grid);

            GridData = model;
        }
        catch (Exception e)
        {
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    public async Task Edit(long Id)
    {
        var component = new RenderComponent<RoleUpdate>();

        component.Set(x => x.Id, Id);

        await ModalService.ShowAsync("ویراش نقش", component);

        await OnBind(_baseGrid);
    }
}