using Services.Models.EmployeDtos;

namespace Services.Repositories.Interface.IEmploye;

public interface IServiceLineTypeService
{
    Task<List<ServiceLineTypeDto>> GetAll();
}