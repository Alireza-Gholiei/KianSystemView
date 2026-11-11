using Services.Models.EmployeDtos.EmployeComplementDtos;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class EmployeComplementService(IHttp http) : IEmployeComplementService
{
    public async Task<List<AddEmployeComplementDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<AddEmployeComplementDto>>($"{StaticUrls.DevUrl}v1/EmployeComplement/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(AddEmployeComplementDto employe)
    {
        try
        {
            var result = await http.PostAsync<AddEmployeComplementDto, bool>($"{StaticUrls.DevUrl}v1/EmployeComplement/Insert", employe);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(EditEmployeComplementDto employe)
    {
        try
        {
            var result = await http.PutAsync<EditEmployeComplementDto, bool>($"{StaticUrls.DevUrl}v1/EmployeComplement/Update", employe);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<EditEmployeComplementDto> GetByEmployeId(long employeId)
    {
        try
        {
            var result = await http.GetAsync<EditEmployeComplementDto>($"{StaticUrls.DevUrl}v1/EmployeComplement/GetByEmployeId/{employeId}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<AddEmployeComplementDto> GetById(long id)
    {
        try
        {
            var result = await http.GetAsync<AddEmployeComplementDto>($"{StaticUrls.DevUrl}v1/EmployeComplement/GetById/{id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}