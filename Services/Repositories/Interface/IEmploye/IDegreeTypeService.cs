using Services.Models.EmployeDtos;

namespace Services.Repositories.Interface.IEmploye;

public interface IDegreeTypeService
{
    Task<List<DegreeTypeDto>> GetAll();
}