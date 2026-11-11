using Services.Models.TrafficDtos;

namespace Services.Repositories.Interface.ITraffic;

public interface ITrafficService
{
    Task<TrafficResultRegisterDto> Register(RegisterTrafficIntertDto model);
    Task<TrafficResultRegisterDto> RegisterManual(ManualRegisterTrafficIntertDto model);
}