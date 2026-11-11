using Services.Models.EmployeDtos;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class ServiceLineTypeService(IHttp http) : IServiceLineTypeService
{
    public async Task<List<ServiceLineTypeDto>> GetAll()
    {
        try
        {
            return await http.GetAsync<List<ServiceLineTypeDto>>($"{StaticUrls.DevUrl}v1/ServiceLineType/GetAll");
        }
        catch (Exception)
        {
            throw;
        }
    }
}