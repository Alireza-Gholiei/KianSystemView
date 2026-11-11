using Services.Models.StartDtos;

namespace Services.Repositories.Interface.IStart;

public interface ITrafficStatusService
{
    Task<List<TrafficStatusDto>> GetAll();
    Task<bool> Insert(TrafficStatusDto model);
    Task<bool> Update(TrafficStatusDto model);
    Task<bool> Delete(long Id);
}