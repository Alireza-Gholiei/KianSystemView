using Services.Models._AuthDtos.PositionDtos;
using Services.Repositories.Interface._IAuth.IPosition;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.Position;

public class PositionService(IHttp http) : IPositionService
{
    public async Task<List<PositionGetSectionHeadPositions>> GetSectionHeadPositions()
    {
        try
        {
            return await http.GetAsync<List<PositionGetSectionHeadPositions>>($"{StaticUrls.SSOUrl}/api/sso/v1/Position/GetSectionHeadPositions");
        }
        catch (Exception)
        {
            throw;
        }
    }
}