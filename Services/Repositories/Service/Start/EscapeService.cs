using Services.Models.StartDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class EscapeService(IHttp http) : IEscapeService
{
    public async Task<List<EscapeDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<EscapeDto>>($"{StaticUrls.DevUrl}v1/Escape/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<EscapeDto> GetById(long Id)
    {
        try
        {
            var result = await http.GetAsync<EscapeDto>($"{StaticUrls.DevUrl}v1/Escape/GetById/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<EscapeDto> GetFirst()
    {
        try
        {
            var result = await http.GetAsync<EscapeDto>($"{StaticUrls.DevUrl}v1/Escape/GetFirst");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(EscapeDto model)
    {
        try
        {
            var result = await http.PostAsync<EscapeDto, bool>($"{StaticUrls.DevUrl}v1/Escape/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(EscapeDto model)
    {
        try
        {
            var result = await http.PutAsync<EscapeDto, bool>($"{StaticUrls.DevUrl}v1/Escape/Update", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Delete(long Id)
    {
        try
        {
            var result = await http.DeleteAsync<bool>($"{StaticUrls.DevUrl}v1/Escape/Delete/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}