using Despro.Blazor.Base.Models;
using Services.Models.VacationDtos.Vacation;
using Services.Models.VacationDtos.VacationCartabl;
using Services.Repositories.Interface.IVacation;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Vacation;

public class VacationService(IHttp http) : IVacationService
{
    public async Task<bool> Insert(VacationAddDto model)
    {
        try
        {
            return await http.PostAsync<VacationAddDto, bool>($"{StaticUrls.DevUrl}v1/Vacation/Insert", model);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> InsertNextStatePlan(VacationInsertNextInstanceDto model)
    {
        try
        {
            return await http.PostAsync<VacationInsertNextInstanceDto, bool>($"{StaticUrls.DevUrl}v1/Vacation/InsertNextStatePlan", model);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GridData<VacationCartablGetDto>> BindCartable(BaseGrid grid)
    {
        try
        {
            var result = await http.GetGridAsync<VacationCartablGetDto>($"{StaticUrls.DevUrl}v1/Vacation/BindCartable", grid);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GridData<VacationGetDto>> BindGrid(BaseGrid grid)
    {
        try
        {
            var result = await http.GetGridAsync<VacationGetDto>($"{StaticUrls.DevUrl}v1/Vacation/BindGrid", grid);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}