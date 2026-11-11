using Services.Models._AuthDtos.GarrisonDtos;
using Services.Repositories.Interface._IAuth.IGarrison;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.Garrison;

public class GarrisonService(IHttp http) : IGarrisonService
{
    public async Task<GarrisonDto> GetSingle()
    {
        try
        {
            return await http.GetAsync<GarrisonDto>($"{StaticUrls.SSOUrl}/api/sso/v1/Garrison/BindSingle");
        }
        catch (Exception)
        {
            throw;
        }
    }
}