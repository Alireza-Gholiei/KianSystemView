using Services.Models.EmployeDtos;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class EmployeMembershipType(IHttp http) : IEmployeMembershipType
{
    public async Task<List<EmployeMembershipTypeDto>> GetAll()
    {
        try
        {
            return await http.GetAsync<List<EmployeMembershipTypeDto>>($"{StaticUrls.DevUrl}v1/EmployeMembershipType/GetAll");
        }
        catch (Exception)
        {
            throw;
        }
    }
}