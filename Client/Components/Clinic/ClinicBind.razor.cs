using Despro.Blazor.Base.Models;
using Microsoft.AspNetCore.Components;
using Services.Models.ClinicDtos;
using Services.Repositories.Interface.IClinic;

namespace Client.Components.Clinic;

public partial class ClinicBind : BaseComponent
{
    [Inject] private IModalService ModalService { get; set; } = null!;
    [Inject] private IClinicService ClinicService { get; set; } = null!;

    private GridData<ClinicGetDto> _employeDtos = new GridData<ClinicGetDto>();


    private async Task OnBind(BaseGrid grid)
    {
        try
        {
            _employeDtos = await ClinicService.GetGrid(grid);
        }
        catch (Exception)
        {
            // ignored
        }
    }

    private async Task EditClinic(long Id)
    {
        try
        {
            var component = new RenderComponent<ClinicEdit>();

            component.Set(x => x.Id, Id);

            await ModalService.ShowAsync("ویراش اطلاعات مراجعین", component);
            await OnBind(new BaseGrid());
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}