using Services.Models.StartDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class ClosedService(IHttp http) : IClosedService
{
    public async Task<List<ClosedDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<ClosedDto>>($"{StaticUrls.DevUrl}v1/Closed/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(ClosedDto model)
    {
        try
        {
            var result = await http.PostAsync<ClosedDto, bool>($"{StaticUrls.DevUrl}v1/Closed/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(ClosedDto model)
    {
        try
        {
            var result = await http.PutAsync<ClosedDto, bool>($"{StaticUrls.DevUrl}v1/Closed/Update", model);

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
            var result = await http.DeleteAsync<bool>($"{StaticUrls.DevUrl}v1/Closed/Delete/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}