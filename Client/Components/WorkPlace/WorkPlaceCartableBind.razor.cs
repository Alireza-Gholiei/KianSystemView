using Despro.Blazor.Base.Models;
using Mapster;
using Microsoft.AspNetCore.Components;
using Services.Models.WorkPlaceDtos.WorkPlace;
using Services.Repositories.Interface.IWorkPlace;
using Storebook.Workflow.Service.WorkflowBaseDtos.InstanceDto;

namespace Client.Components.WorkPlace;

public partial class WorkPlaceCartableBind : BaseComponent
{
    [Inject] private IWorkPlaceService _workPlaceService { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private IModalService _modalService { get; set; }

    private GridData<WorkPlaceGetCartableDto> _gridData { get; set; } = new GridData<WorkPlaceGetCartableDto>();

    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _gridData = await _workPlaceService.BindCartable(grid);
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
            var model = insertNextInstanceDto.Adapt<WorkPlaceNextInstanceDto>();

            var result = await _workPlaceService.RequestReleaseNextStatePlan(model);

            if (result)
            {
                try
                {
                    _modalService.Close();
                }
                catch (Exception)
                {
                    // ignored
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