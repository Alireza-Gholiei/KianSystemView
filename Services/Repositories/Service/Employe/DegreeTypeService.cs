using Services.Models.EmployeDtos;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class DegreeTypeService(IHttp http) : IDegreeTypeService
{
    public async Task<List<DegreeTypeDto>> GetAll()
    {
        try
        {
            return await http.GetAsync<List<DegreeTypeDto>>($"{StaticUrls.DevUrl}v1/DegreeType/GetAll");
        }
        catch (Exception)
        {
            throw;
        }
    }
}