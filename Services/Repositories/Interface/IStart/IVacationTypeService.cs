using Services.Models.StartDtos;

namespace Services.Repositories.Interface.IStart;

public interface IVacationTypeService
{
    Task<List<VacationTypeDto>> GetAll();
    Task<bool> Insert(VacationTypeDto model);
    Task<bool> Update(VacationTypeDto model);
    Task<bool> Delete(long Id);
}