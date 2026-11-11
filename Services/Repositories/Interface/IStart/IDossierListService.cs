using Services.Models.StartDtos.DossierListDtos;

namespace Services.Repositories.Interface.IStart;

public interface IDossierListService
{
    Task<List<DossierListDto>> GetAll();
    Task<List<DossierListDto>> GetNotUploaded(long employeId);
    Task<List<DossierGetUploadedDto>> GetUploaded(long employeId);
    Task<bool> Insert(DossierListDto model);
    Task<bool> Update(DossierListDto model);
    Task<bool> Delete(long Id);
}