using Despro.Blazor.Base.Models;
using Services.Models.ClinicDtos;

namespace Services.Repositories.Interface.IClinic;

public interface IClinicService
{
    Task<GridData<ClinicGetDto>> GetGrid(BaseGrid grid);
    Task<ClinicGetDto> GetById(long id);
    Task<ClinicGetDto> GetByEmployeId(long EmployeId);
    Task<bool> Insert(ClinicAddDto employe);
    Task<bool> Update(ClinicEditDto employe);
}