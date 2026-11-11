using Services.Models.StartDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class ResidenceTypeService(IHttp http) : IResidenceTypeService
{
    public async Task<List<ResidenceTypeDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<ResidenceTypeDto>>($"{StaticUrls.DevUrl}v1/ResidenceType/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(ResidenceTypeDto model)
    {
        try
        {
            var result = await http.PostAsync<ResidenceTypeDto, bool>($"{StaticUrls.DevUrl}v1/ResidenceType/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(ResidenceTypeDto model)
    {
        try
        {
            var result = await http.PutAsync<ResidenceTypeDto, bool>($"{StaticUrls.DevUrl}v1/ResidenceType/Update", model);

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
            var result = await http.DeleteAsync<bool>($"{StaticUrls.DevUrl}v1/ResidenceType/Delete/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}