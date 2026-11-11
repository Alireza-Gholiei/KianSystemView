using Services.Models.StartDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class TrafficStatusService(IHttp http) : ITrafficStatusService
{
    public async Task<List<TrafficStatusDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<TrafficStatusDto>>($"{StaticUrls.DevUrl}v1/TrafficStatus/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(TrafficStatusDto model)
    {
        try
        {
            var result = await http.PostAsync<TrafficStatusDto, bool>($"{StaticUrls.DevUrl}v1/TrafficStatus/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(TrafficStatusDto model)
    {
        try
        {
            var result = await http.PutAsync<TrafficStatusDto, bool>($"{StaticUrls.DevUrl}v1/TrafficStatus/Update", model);

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
            var result = await http.DeleteAsync<bool>($"{StaticUrls.DevUrl}v1/TrafficStatus/Delete/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}