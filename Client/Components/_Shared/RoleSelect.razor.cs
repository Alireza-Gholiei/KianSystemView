using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Services.Models._AuthDtos.UserDtos;
using Services.Repositories.Interface._IAuth.ISSO;
using Storebook.Service.AuthorizationServices;

namespace Client.Components._Shared;

public partial class RoleSelect : BaseComponent
{
    [Inject] private AuthenticationStateProvider AuthenticationStateService { get; set; } = null!;
    [Inject] private ISsoService UserService { get; set; } = null!;
    [Inject] private IModalService ModalService { get; set; } = null!;

    private List<UserRoleDto> UserRoles { get; set; } = [];
    private long RoleId { get; set; }
    private string RoleName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        RoleId = await ((AuthStateProvider)AuthenticationStateService).GetRole();

        UserRoles = await UserService.GetUserRoles();

        RoleName = UserRoles.FirstOrDefault(x => x.RoleId == RoleId)?.RoleName;
    }

    private async Task Submit()
    {
        await ((AuthStateProvider)AuthenticationStateService).SetRole(RoleId.ToString());

        RoleName = UserRoles.FirstOrDefault(x => x.RoleId == RoleId).RoleName;

        ModalService.Close();
    }
}