using Despro.Blazor.Base.Models;
using Services.Models.ClinicDtos;
using Services.Repositories.Interface.IClinic;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Clinic;

public class ClinicService(IHttp http) : IClinicService
{
    public async Task<GridData<ClinicGetDto>> GetGrid(BaseGrid grid)
    {
        try
        {
            var result = await http.GetGridAsync<ClinicGetDto>($"{StaticUrls.DevUrl}v1/Clinic/GetGrid", grid);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<ClinicGetDto> GetById(long id)
    {
        try
        {
            var result = await http.GetAsync<ClinicGetDto>($"{StaticUrls.DevUrl}v1/Clinic/GetById/{id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<ClinicGetDto> GetByEmployeId(long EmployeId)
    {
        try
        {
            var result = await http.GetAsync<ClinicGetDto>($"{StaticUrls.DevUrl}v1/Clinic/GetByEmployeId/{EmployeId}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }


    public async Task<bool> Insert(ClinicAddDto model)
    {
        var result = await http.PostAsync<ClinicAddDto, bool>($"{StaticUrls.DevUrl}v1/Clinic/Insert", model);

        return result;
    }

    public async Task<bool> Update(ClinicEditDto employe)
    {
        var result = await http.PutAsync<ClinicEditDto, bool>($"{StaticUrls.DevUrl}v1/Clinic/Update", employe);
        return result;
    }
}