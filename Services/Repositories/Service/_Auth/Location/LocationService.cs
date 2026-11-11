using Services.Models._AuthDtos.LocationDtos;
using Services.Repositories.Interface._IAuth.ILocation;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Auth.Location;

public class LocationService(IHttp http) : ILocationService
{
    public async Task<LocationDto> GetById(long Id)
    {
        try
        {
            var result = await http.GetAsync<LocationDto>($"{StaticUrls.SSOUrl}/api/sso/v1/Location/GetById/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<long> GetParentId(long Id)
    {
        try
        {
            var result = await http.GetAsync<long>($"{StaticUrls.SSOUrl}/api/sso/v1/Location/GetParentId/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<LocationDto>> GetCity()
    {
        try
        {
            var result = await http.GetAsync<List<LocationDto>>($"{StaticUrls.SSOUrl}/api/sso/v1/Location/GetCity");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<LocationDto>> GetCityByProvince(long ProvinceId)
    {
        try
        {
            var result = await http.GetAsync<List<LocationDto>>($"{StaticUrls.SSOUrl}/api/sso/v1/Location/GetCityByProvince/{ProvinceId}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<LocationDto>> GetProvince()
    {
        try
        {
            var result = await http.GetAsync<List<LocationDto>>($"{StaticUrls.SSOUrl}/api/sso/v1/Location/GetProvince");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}