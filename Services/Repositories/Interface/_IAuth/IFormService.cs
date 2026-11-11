using Services.Models._AuthDtos.FormDtos;

namespace Services.Repositories.Interface._IAuth;

public interface IFormService
{
    Task<List<FormGetMenuDto>> GetMenu();
    Task<List<FormGetChildDto>> GetChild(long? Id = null);
}