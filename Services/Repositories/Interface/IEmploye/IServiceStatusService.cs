using Services.Models.EmployeDtos.ServiceStatusDtos;

namespace Services.Repositories.Interface.IEmploye;

public interface IServiceStatusService
{
    Task<bool> Insert(AddServiceStatusDto employe);
    Task<bool> Update(EditServiceStatusDto employe);
    Task<GetServiceStatusDto> GetById(long id);
    Task<GetLastServiseStatusDto> GetLastServiseStatus(long employeId);
    Task<GetServiceStatusDto> GetByEmployeComplementId(long EmployeComplementId);
}