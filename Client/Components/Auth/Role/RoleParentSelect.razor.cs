using Despro.Blazor.Display.Components.TreeViews;
using Despro.Blazor.Modal.ModalGenerals;
using Mapster;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.RoleDtos;
using Services.Repositories.Interface._IAuth.IRole;

namespace Client.Components.Auth.Role;

public partial class RoleParentSelect : BaseComponent
{
    [Inject] private IRoleService RoleService { get; set; }
    [Inject] IModalService ModalService { get; set; }

    [Parameter] public long Selected { get; set; }


    private long SelectedId { get; set; }
    public RoleGetChildDto InputRole { get; set; } = new();
    public RoleGetChildDto SelectedRole { get; set; } = new();
    public List<RoleGetChildDto> Roles { get; set; } = [];
    public TreeView<RoleGetChildDto> RoleTreeView { get; set; } = null!;


    protected override async Task OnInitializedAsync()
    {
        SelectedId = Selected;

        InputRole = new RoleGetChildDto();
        Roles = await RoleService.GetChild();
        if (Roles.Any(x => SelectedId == x.Id))
        {
            InputRole = Roles.FirstOrDefault(x => SelectedId == x.Id)!;
            await OnSelectedChanged(InputRole);
        }

        var modelParent = await RoleService.GetById(Selected);

        InputRole = modelParent.Adapt<RoleGetChildDto>();
    }

    #region TreeView
    private async Task<IList<RoleGetChildDto>> GetSub(RoleGetChildDto model)
    {
        var list = await RoleService.GetChild(model.Id);
        if (list.Any(x => x.Id == SelectedId))
        {
            InputRole = list.FirstOrDefault(x => SelectedId == x.Id)!;
            await OnSelectedChanged(InputRole);
            await RoleTreeView.SelectedItemChanged.InvokeAsync(InputRole);
        }

        return list;
    }

    private Task OnSelectedChanged(RoleGetChildDto model)
    {
        SelectedRole = model;
        return Task.CompletedTask;
    }
    #endregion

    private void Submit()
    {
        ModalService.Close(ModalResult.Ok(SelectedRole));
    }

    private void ClearAccess()
    {
        ModalService.Close();
    }

    private void Close()
    {
        ModalService.Close(ModalResult.Ok(InputRole));
    }
}