using Services.Models.StartDtos;

namespace Services.Repositories.Interface.IStart;

public interface IClosedService
{
    Task<List<ClosedDto>> GetAll();
    Task<bool> Insert(ClosedDto model);
    Task<bool> Update(ClosedDto model);
    Task<bool> Delete(long Id);
}