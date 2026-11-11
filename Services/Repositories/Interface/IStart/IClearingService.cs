using Services.Models.StartDtos;

namespace Services.Repositories.Interface.IStart;

public interface IClearingService
{
    Task<List<ClearingDto>> GetAll();
    Task<bool> Insert(ClearingDto model);
    Task<bool> Update(ClearingDto model);
    Task<bool> Delete(long Id);
}