using Services.Models.TrafficDtos;
using Services.Repositories.Interface.ITraffic;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Traffic;

public class TrafficService(IHttp http) : ITrafficService
{
    public async Task<TrafficResultRegisterDto> Register(RegisterTrafficIntertDto model)
    {
        try
        {
            return await http.PostAsync<RegisterTrafficIntertDto, TrafficResultRegisterDto>($"{StaticUrls.DevUrl}v1/Traffic/Register", model);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<TrafficResultRegisterDto> RegisterManual(ManualRegisterTrafficIntertDto model)
    {
        try
        {
            return await http.PostAsync<ManualRegisterTrafficIntertDto, TrafficResultRegisterDto>($"{StaticUrls.DevUrl}v1/Traffic/RegisterManual", model);
        }
        catch (Exception)
        {
            throw;
        }
    }
}