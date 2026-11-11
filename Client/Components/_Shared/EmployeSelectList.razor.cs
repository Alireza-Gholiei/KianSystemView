using Despro.Blazor.Base.Models;
using Despro.Blazor.Modal.ModalGenerals;
using Microsoft.AspNetCore.Components;
using Services.Models.EmployeDtos.Employe;
using Services.Repositories.Interface.IEmploye;

namespace Client.Components._Shared;

public partial class EmployeSelectList : BaseComponent
{
    [Inject] IEmployeService EmployeService { get; set; }
    [Inject] private IModalService ModalService { get; set; }

    private GridData<EmployeGetForDetailDto> _employeDtos = new GridData<EmployeGetForDetailDto>();

    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _employeDtos = await EmployeService.GetForDetail(grid);
        }
        catch (Exception)
        {
            // ignored
        }
    }

    public void Select(EmployeGetForDetailDto context)
    {
        try
        {
            ModalService.Close(ModalResult.Ok(context));
        }
        catch (Exception)
        {
            // ignored
        }
    }
}
