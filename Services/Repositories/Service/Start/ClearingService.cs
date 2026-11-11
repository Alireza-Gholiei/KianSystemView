using Services.Models.StartDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class ClearingService(IHttp http) : IClearingService
{
    public async Task<List<ClearingDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<ClearingDto>>($"{StaticUrls.DevUrl}v1/Clearing/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(ClearingDto model)
    {
        try
        {
            var result = await http.PostAsync<ClearingDto, bool>($"{StaticUrls.DevUrl}v1/Clearing/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(ClearingDto model)
    {
        try
        {
            var result = await http.PutAsync<ClearingDto, bool>($"{StaticUrls.DevUrl}v1/Clearing/Update", model);

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
            var result = await http.DeleteAsync<bool>($"{StaticUrls.DevUrl}v1/Clearing/Delete/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}