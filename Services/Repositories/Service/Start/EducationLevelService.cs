using Services.Models.StartDtos;
using Services.Repositories.Interface.IStart;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service.Start;

public class EducationLevelService(IHttp http) : IEducationLevelService
{
    public async Task<List<EducationLevelDto>> GetAll()
    {
        try
        {
            var result = await http.GetAsync<List<EducationLevelDto>>($"{StaticUrls.DevUrl}v1/EducationLevel/GetAll");

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Insert(EducationLevelDto model)
    {
        try
        {
            var result = await http.PostAsync<EducationLevelDto, bool>($"{StaticUrls.DevUrl}v1/EducationLevel/Insert", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> Update(EducationLevelDto model)
    {
        try
        {
            var result = await http.PutAsync<EducationLevelDto, bool>($"{StaticUrls.DevUrl}v1/EducationLevel/Update", model);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}