using Despro.Blazor.Base.Models;
using Mapster;
using Microsoft.AspNetCore.Components;
using Services.Models.VacationDtos.VacationCartabl;
using Services.Repositories.Interface.IVacation;
using Storebook.Workflow.Service.WorkflowBaseDtos.InstanceDto;

namespace Client.Components.Vacation;

public partial class VacationCartableBind : BaseComponent
{
    [Inject] private IVacationService _vacationService { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private IModalService _modalService { get; set; }

    private GridData<VacationCartablGetDto> _gridData { get; set; } = new GridData<VacationCartablGetDto>();

    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _gridData = await _vacationService.BindCartable(grid);
        }
        catch (Exception e)
        {
            _toastService.ErrorAlert(e.Message);
        }
    }

    public async Task Submit(InsertNextInstanceDto insertNextInstanceDto)
    {
        try
        {
            var model = insertNextInstanceDto.Adapt<VacationInsertNextInstanceDto>();

            var result = await _vacationService.InsertNextStatePlan(model);

            if (result)
            {
                try
                {
                    _modalService.Close();
                }
                catch (Exception)
                {
                }
                _toastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}