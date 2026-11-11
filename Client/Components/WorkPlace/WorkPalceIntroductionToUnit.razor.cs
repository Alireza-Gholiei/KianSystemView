using Mapster;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.PositionDtos;
using Services.Models.WorkPlaceDtos.WorkPlace;
using Services.Repositories.Interface._IAuth.IPosition;
using Services.Repositories.Interface.IWorkPlace;
using Storebook.Workflow.Service.WorkflowBaseDtos.InstanceDto;

namespace Client.Components.WorkPlace;

public partial class WorkPalceIntroductionToUnit : BaseComponent
{
    [Parameter, EditorRequired] public long WfStateId { get; set; }
    [Parameter, EditorRequired] public long InstanceId { get; set; }

    [Inject] private IWorkPlaceService _workPlaceService { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private IPositionService _positionService { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    private List<PositionGetSectionHeadPositions> PositionList { get; set; } = [];
    private WorkPlaceNextInstanceDto NextInstanceDtos { get; set; } = new();
    private WorkPlaceGetByIdDto WorkPlaceDto { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            PositionList = await _positionService.GetSectionHeadPositions();
            WorkPlaceDto = await _workPlaceService.GetById(InstanceId);
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
            insertNextInstanceDto.Adapt(NextInstanceDtos);

            var result = await _workPlaceService.RequestReleaseNextStatePlan(NextInstanceDtos);

            if (result)
            {
                _toastService.SuccessAlert();
                _navigationManager.NavigateTo("WorkPlace/BindVacationCartabl");
            }
        }
        catch (Exception e)
        {
            _toastService.ErrorAlert(e.Message);
        }
    }
}