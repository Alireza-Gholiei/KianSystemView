using Services.Models.StartDtos;

namespace Services.Repositories.Interface.IStart;

public interface IResidenceTypeService
{
    Task<List<ResidenceTypeDto>> GetAll();
    Task<bool> Insert(ResidenceTypeDto model);
    Task<bool> Update(ResidenceTypeDto model);
    Task<bool> Delete(long Id);
}