using Services.Models.StartDtos.DossierListDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class DossierListService(IHttp http) : IDossierListService
{
    public async Task<List<DossierListDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<DossierListDto>>($"{StaticUrls.DevUrl}v1/DossierList/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<DossierListDto>> GetNotUploaded(long employeId)
    {
        try
        {
            var result = await http.GetAsync<List<DossierListDto>>($"{StaticUrls.DevUrl}v1/DossierList/GetNotUploaded/{employeId}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<DossierGetUploadedDto>> GetUploaded(long employeId)
    {
        try
        {
            var result = await http.GetAsync<List<DossierGetUploadedDto>>($"{StaticUrls.DevUrl}v1/DossierList/GetUploaded/{employeId}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(DossierListDto model)
    {
        try
        {
            var result = await http.PostAsync<DossierListDto, bool>($"{StaticUrls.DevUrl}v1/DossierList/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(DossierListDto model)
    {
        try
        {
            var result = await http.PutAsync<DossierListDto, bool>($"{StaticUrls.DevUrl}v1/DossierList/Update", model);

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
            var result = await http.DeleteAsync<bool>($"{StaticUrls.DevUrl}v1/DossierList/Delete/{Id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}