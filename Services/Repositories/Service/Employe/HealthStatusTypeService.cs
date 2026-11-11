using Services.Models.EmployeDtos;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class HealthStatusTypeService(IHttp http) : IHealthStatusTypeService
{
    public async Task<List<HealthStatusTypeDto>> GetAll()
    {
        try
        {
            return await http.GetAsync<List<HealthStatusTypeDto>>($"{StaticUrls.DevUrl}v1/HealthStatusType/GetAll");
        }
        catch (Exception)
        {
            throw;
        }
    }
}