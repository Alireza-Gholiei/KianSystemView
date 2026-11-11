using Services.Models._AuthDtos.GarrisonDtos;

namespace Services.Repositories.Interface._IAuth.IGarrison;

public interface IGarrisonService
{
    Task<GarrisonDto> GetSingle();
}