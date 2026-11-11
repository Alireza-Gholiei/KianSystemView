using Services.Models.EmployeDtos;

namespace Services.Repositories.Interface.IEmploye;

public interface IHealthStatusTypeService
{
    Task<List<HealthStatusTypeDto>> GetAll();
}