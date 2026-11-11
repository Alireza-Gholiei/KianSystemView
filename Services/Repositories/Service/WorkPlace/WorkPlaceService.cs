using Despro.Blazor.Base.Models;
using Services.Models.WorkPlaceDtos.WorkPlace;
using Services.Repositories.Interface.IWorkPlace;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.WorkPlace;

public class WorkPlaceService(IHttp http) : IWorkPlaceService
{
    public async Task<WorkPlaceGetByIdDto> GetById(long Id)
    {
        try
        {
            var result = await http.GetAsync<WorkPlaceGetByIdDto>($"{StaticUrls.DevUrl}v1/WorkPlace/GetById/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RequestRelease(WorkPlaceRequestReleaseDto model)
    {
        try
        {
            var result = await http.PostAsync<WorkPlaceRequestReleaseDto, bool>($"{StaticUrls.DevUrl}v1/WorkPlace/RequestRelease", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RequestReleaseNextStatePlan(WorkPlaceNextInstanceDto model)
    {
        try
        {
            return await http.PostAsync<WorkPlaceNextInstanceDto, bool>($"{StaticUrls.DevUrl}v1/WorkPlace/RequestReleaseNextStatePlan", model);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<WorkPlaceGetCurrentRankDto> GetCurrentRank(long EmployeId)
    {
        try
        {
            var result = await http.GetAsync<WorkPlaceGetCurrentRankDto>($"{StaticUrls.DevUrl}v1/WorkPlace/GetCurrentRank/{EmployeId}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GridData<WorkPlaceGetCartableDto>> BindCartable(BaseGrid grid)
    {
        try
        {
            var result = await http.GetGridAsync<WorkPlaceGetCartableDto>($"{StaticUrls.DevUrl}v1/WorkPlace/BindCartable/", grid);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}