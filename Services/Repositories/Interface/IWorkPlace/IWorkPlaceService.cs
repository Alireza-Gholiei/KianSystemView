using Despro.Blazor.Base.Models;
using Services.Models.WorkPlaceDtos.WorkPlace;

namespace Services.Repositories.Interface.IWorkPlace;

public interface IWorkPlaceService
{
    Task<bool> RequestRelease(WorkPlaceRequestReleaseDto model);
    Task<bool> RequestReleaseNextStatePlan(WorkPlaceNextInstanceDto model);
    Task<WorkPlaceGetCurrentRankDto> GetCurrentRank(long EmployeId);
    Task<GridData<WorkPlaceGetCartableDto>> BindCartable(BaseGrid grid);
    Task<WorkPlaceGetByIdDto> GetById(long Id);
}