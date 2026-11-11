using Services.Models.EmployeDtos.ServiceStatusDtos;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class ServiceStatusService(IHttp http) : IServiceStatusService
{
    public async Task<bool> Insert(AddServiceStatusDto employe)
    {
        try
        {
            return await http.PostAsync<AddServiceStatusDto, bool>($"{StaticUrls.DevUrl}v1/ServiceStatus/Insert", employe);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(EditServiceStatusDto employe)
    {
        try
        {
            return await http.PutAsync<EditServiceStatusDto, bool>($"{StaticUrls.DevUrl}v1/ServiceStatus/Update", employe);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GetServiceStatusDto> GetById(long id)
    {
        try
        {
            return await http.GetAsync<GetServiceStatusDto>($"{StaticUrls.DevUrl}v1/ServiceStatus/GetById/{id}");
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GetLastServiseStatusDto> GetLastServiseStatus(long employeId)
    {
        try
        {
            return await http.GetAsync<GetLastServiseStatusDto>($"{StaticUrls.DevUrl}v1/ServiceStatus/GetLastServiseStatus/{employeId}");
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GetServiceStatusDto> GetByEmployeComplementId(long EmployeComplementId)
    {
        return await http.GetAsync<GetServiceStatusDto>($"{StaticUrls.DevUrl}v1/ServiceStatus/GetByEmployeComplementId/{EmployeComplementId}");
    }
}