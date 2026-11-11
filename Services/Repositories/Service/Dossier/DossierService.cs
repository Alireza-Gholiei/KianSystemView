using Services.Models.DossierDtos;
using Services.Repositories.Interface.IDossier;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Dossier;

public class DossierService(IHttp http) : IDossierService
{
    public async Task<List<DossierGetDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<DossierGetDto>>($"{StaticUrls.DevUrl}v1/Dossier/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<DossierGetTreeDto>> GetTree(long EmployeId)
    {
        try
        {
            var result = await http.GetAsync<List<DossierGetTreeDto>>($"{StaticUrls.DevUrl}v1/Dossier/GetForBind/{EmployeId}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(DossierAddDto model)
    {
        try
        {
            var result = await http.PostFormAsync<DossierAddDto, bool>($"{StaticUrls.DevUrl}v1/Dossier/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(DossierEditDto model)
    {
        try
        {
            var result = await http.PutFormAsync<DossierEditDto, bool>($"{StaticUrls.DevUrl}v1/Dossier/Update", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}