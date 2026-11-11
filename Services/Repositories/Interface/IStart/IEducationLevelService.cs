using Services.Models.StartDtos;

namespace Services.Repositories.Interface.IStart;

public interface IEducationLevelService
{
    Task<List<EducationLevelDto>> GetAll();
    Task<bool> Insert(EducationLevelDto model);
    Task<bool> Update(EducationLevelDto model);
}