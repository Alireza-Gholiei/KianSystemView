using Microsoft.AspNetCore.Components;
using Services.Models.WorkPlaceDtos.WorkPlace;
using Services.Repositories.Interface.IWorkPlace;

namespace Client.Components.WorkPlace;

public partial class WorkPlaceRequestRelease : BaseComponent
{
    [Inject] private IToastService ToastService { get; set; }
    [Inject] private IWorkPlaceService WorkPlaceService { get; set; }
    public WorkPlaceRequestReleaseDto _requestReleaseDto { get; set; } = new WorkPlaceRequestReleaseDto();
    public WorkPlaceGetCurrentRankDto WorkPlaceGetCurrentRankDto { get; set; } = new WorkPlaceGetCurrentRankDto();

    public async Task Submit()
    {
        try
        {
            var result = await WorkPlaceService.RequestRelease(_requestReleaseDto);
            if (result)
            {
                _requestReleaseDto = new WorkPlaceRequestReleaseDto();
                ToastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }

    public async Task GetRank(long EmployeId)
    {
        try
        {
            _requestReleaseDto.EmployeId = EmployeId;

            WorkPlaceGetCurrentRankDto = await WorkPlaceService.GetCurrentRank(EmployeId);
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }
}