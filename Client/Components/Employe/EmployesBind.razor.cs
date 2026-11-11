using Despro.Blazor.Base.Models;
using Microsoft.AspNetCore.Components;
using Services.Models.EmployeDtos.Employe;
using Services.Repositories.Interface.IEmploye;

namespace Client.Components.Employe;

public partial class EmployesBind : BaseComponent
{
    [Inject] private IModalService ModalService { get; set; }
    [Inject] IEmployeService EmployeService { get; set; }
    private GridData<GetMinorEmployeDto> _employeDtos = new GridData<GetMinorEmployeDto>();

    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _employeDtos = await EmployeService.GetMinor(grid);
        }
        catch (Exception)
        {
            // ignored
        }
    }

    private async Task AddComplementEmploye(long employeId)
    {
        var component = new RenderComponent<EmployeComplementAdd>();

        component.Set(x => x.EmployeId, employeId);

        await ModalService.ShowAsync("افزودن اطلاعات تکمیلی سرباز", component);
    }

    private async Task EditComplementEmploye(long employeId)
    {
        var component = new RenderComponent<EmployeComplementEdit>();

        component.Set(x => x.EmployeId, employeId);

        await ModalService.ShowAsync("ویرایش اطلاعات تکمیلی سرباز", component);
    }

    private async Task AddServiceStatus(long employeId)
    {
        try
        {
            var component = new RenderComponent<ServiceStatusAdd>();

            component.Set(x => x.EmployeId, employeId);

            await ModalService.ShowAsync("تعین وضعیت خدمتی", component);
        }
        catch (Exception)
        {
            // ignored
        }
    }
}