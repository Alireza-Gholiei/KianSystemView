using Despro.Blazor.Modal.ModalGenerals;
using Microsoft.AspNetCore.Components;

namespace Client.Components.Auth.Role;

public partial class RoleFormSelect : BaseComponent
{
    [Inject] IModalService ModalService { get; set; } = null!;

    [Parameter] public List<long> Selected { get; set; } = [];

    private List<long> SelectedIds { get; set; } = [];

    protected override Task OnInitializedAsync()
    {
        SelectedIds = Selected;

        return base.OnInitializedAsync();
    }

    private void Submit()
    {
        ModalService.Close(ModalResult.Ok(SelectedIds.Distinct().ToList()));
    }

    private void ClearAccess()
    {
        ModalService.Close();
    }

    private void Close()
    {
        ModalService.Close(ModalResult.Ok(Selected.Distinct().ToList()));
    }
}