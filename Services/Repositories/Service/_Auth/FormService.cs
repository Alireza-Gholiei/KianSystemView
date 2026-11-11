using Services.Models._AuthDtos.FormDtos;
using Services.Repositories.Interface._IAuth;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth;

public class FormService(IHttp http) : IFormService
{
    private readonly string _baseUrl = $"{StaticUrls.SSOUrl}/api/sso/v1/Form";

    public async Task<List<FormGetMenuDto>> GetMenu()
    {
        return await http.GetAsync<List<FormGetMenuDto>>($"{_baseUrl}/GetMenu");
    }

    public async Task<List<FormGetChildDto>> GetChild(long? Id = null)
    {
        if (Id is null)
        {
            return await http.GetAsync<List<FormGetChildDto>>($"{_baseUrl}/GetChild");
        }
        return await http.GetAsync<List<FormGetChildDto>>($"{_baseUrl}/GetChild/{Id}");
    }
}