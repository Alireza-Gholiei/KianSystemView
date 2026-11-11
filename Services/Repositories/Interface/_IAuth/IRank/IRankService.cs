using Services.Models._AuthDtos.RankDetailDtos;

namespace Services.Repositories.Interface._IAuth.IRank;

public interface IRankService
{
    Task<RankDetailDto> RankDetail(long RankId);
}