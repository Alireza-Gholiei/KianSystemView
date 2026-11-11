using Services.Models.StartDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class VacationTypeService(IHttp http) : IVacationTypeService
{
    public async Task<List<VacationTypeDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<VacationTypeDto>>($"{StaticUrls.DevUrl}v1/VacationType/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(VacationTypeDto model)
    {
        try
        {
            var result = await http.PostAsync<VacationTypeDto, bool>($"{StaticUrls.DevUrl}v1/VacationType/Insert", model);

            return result;
        }
        catch(Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(VacationTypeDto model)
    {
        try
        {
            var result = await http.PutAsync<VacationTypeDto, bool>($"{StaticUrls.DevUrl}v1/VacationType/Update", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Delete(long Id)
    {
        try
        {
            var result = await http.DeleteAsync<bool>($"v1/VacationType/Delete/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}