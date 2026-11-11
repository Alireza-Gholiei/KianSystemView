using Services.Models.DossierDtos;
namespace Services.Repositories.Interface.IDossier;

public interface IDossierService
{
    Task<List<DossierGetDto>> GetAll();
    Task<List<DossierGetTreeDto>> GetTree(long EmployeId);
    Task<bool> Insert(DossierAddDto model);
    Task<bool> Update(DossierEditDto model);
}