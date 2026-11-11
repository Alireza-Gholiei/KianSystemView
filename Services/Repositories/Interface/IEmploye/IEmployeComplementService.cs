using Services.Models.EmployeDtos.EmployeComplementDtos;

namespace Services.Repositories.Interface.IEmploye;

public interface IEmployeComplementService
{
    Task<List<AddEmployeComplementDto>> GetAll();
    Task<bool> Insert(AddEmployeComplementDto employe);
    Task<bool> Update(EditEmployeComplementDto employe);
    Task<EditEmployeComplementDto> GetByEmployeId(long employeId);
    Task<AddEmployeComplementDto> GetById(long id);
}