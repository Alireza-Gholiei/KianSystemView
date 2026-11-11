using Services.Models.StartDtos;

namespace Services.Repositories.Interface.IStart;

public interface IEscapeService
{
    Task<List<EscapeDto>> GetAll();
    Task<EscapeDto> GetById(long Id);
    Task<EscapeDto> GetFirst();
    Task<bool> Insert(EscapeDto model);
    Task<bool> Update(EscapeDto model);
    Task<bool> Delete(long Id);
}