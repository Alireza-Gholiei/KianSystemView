using Despro.Blazor.Base.Models;
using Services.Models.EmployeDtos.Employe;

namespace Services.Repositories.Interface.IEmploye;

public interface IEmployeService
{
    Task<GridData<GetEmployeDto>> GetAll(BaseGrid grid);
    Task<GridData<GetMinorEmployeDto>> GetMinor(BaseGrid grid);
    Task<GridData<EmployeGetForDetailDto>> GetForDetail(BaseGrid grid);
    Task<GetEmployeDto> GetById(long id);
    Task<GetEmployeDto> GetByNationalCode(string nationalCode);
    Task<EmployeGetForDetailDto> GetByNationalCodeForDetail(string nationalCode);
    Task<bool> Insert(AddEmployeDto employe);
    Task<bool> Update(EditEmployeDto employe);
}