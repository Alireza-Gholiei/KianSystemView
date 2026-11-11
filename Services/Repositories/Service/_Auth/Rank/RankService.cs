using Services.Models._AuthDtos.RankDetailDtos;
using Services.Repositories.Interface._IAuth.IRank;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.Rank;

public class RankService(IHttp http) : IRankService
{
    public async Task<RankDetailDto> RankDetail(long RankId)
    {
        try
        {
            return await http.GetAsync<RankDetailDto>($"{StaticUrls.SSOUrl}/api/sso/v1/Rank/GetForEmployeWorkPlace/{RankId}");
        }
        catch (Exception)
        {
            throw;
        }
    }
}