using Services.Models.EmployeDtos;

namespace Services.Repositories.Interface.IEmploye;

public interface IServiceStatusTypeService
{
    Task<List<ServiceStatusTypeDto>> GetAll();
}