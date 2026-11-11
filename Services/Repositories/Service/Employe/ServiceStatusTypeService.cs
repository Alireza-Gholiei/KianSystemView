using Services.Models.EmployeDtos;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class ServiceStatusTypeService(IHttp http) : IServiceStatusTypeService
{
    public async Task<List<ServiceStatusTypeDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<ServiceStatusTypeDto>>($"{StaticUrls.DevUrl}v1/ServiceStatusType/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}