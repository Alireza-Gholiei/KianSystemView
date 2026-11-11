using Despro.Blazor.Base.Models;
using Services.Models.EmployeDtos.Employe;
using Services.Repositories.Interface.IEmploye;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Employe;

public class EmployeService(IHttp http) : IEmployeService
{
    public async Task<GridData<GetEmployeDto>> GetAll(BaseGrid grid)
    {
        try
        {
            var result = await http.GetGridAsync<GetEmployeDto>($"{StaticUrls.DevUrl}v1/Employe/GetAll", grid);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GridData<GetMinorEmployeDto>> GetMinor(BaseGrid grid)
    {
        try
        {
            var result = await http.GetGridAsync<GetMinorEmployeDto>($"{StaticUrls.DevUrl}v1/Employe/GetAll", grid);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GridData<EmployeGetForDetailDto>> GetForDetail(BaseGrid grid)
    {
        try
        {
            var result = await http.GetGridAsync<EmployeGetForDetailDto>($"{StaticUrls.DevUrl}v1/Employe/GetAll", grid);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GetEmployeDto> GetById(long id)
    {
        try
        {
            var result = await http.GetAsync<GetEmployeDto>($"{StaticUrls.DevUrl}v1/Employe/GetById/{id}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GetEmployeDto> GetByNationalCode(string nationalCode)
    {
        try
        {
            var result = await http.GetAsync<GetEmployeDto>($"{StaticUrls.DevUrl}v1/Employe/GetByNationalCode/{nationalCode}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<EmployeGetForDetailDto> GetByNationalCodeForDetail(string nationalCode)
    {
        try
        {
            var result = await http.GetAsync<EmployeGetForDetailDto>($"{StaticUrls.DevUrl}v1/Employe/GetByNationalCodeForDetail/{nationalCode}");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(AddEmployeDto employe)
    {
        try
        {
            var result = await http.PostFormAsync<AddEmployeDto, bool>($"{StaticUrls.DevUrl}v1/Employe/Insert", employe);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(EditEmployeDto employe)
    {
        try
        {
            var result = await http.PutFormAsync<EditEmployeDto, bool>($"{StaticUrls.DevUrl}v1/Employe/Update", employe);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}