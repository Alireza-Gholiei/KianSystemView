using Services.Models._AuthDtos.LocationDtos;

namespace Services.Repositories.Interface._IAuth.ILocation;

public interface ILocationService
{
    Task<LocationDto> GetById(long Id);
    Task<long> GetParentId(long Id);
    Task<List<LocationDto>> GetCity();
    Task<List<LocationDto>> GetCityByProvince(long ProvinceId);
    Task<List<LocationDto>> GetProvince();
}