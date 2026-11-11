using Microsoft.AspNetCore.Components;
using Services.Models.ClinicDtos;
using Services.Repositories.Interface.IClinic;

namespace Client.Components.Clinic;

public partial class ClinicAdd : BaseComponent
{
    public ClinicAddDto ModelDto { get; set; } = new ClinicAddDto();
    [Inject] private IToastService ToastService { get; set; }
    [Inject] private IClinicService ClinicService { get; set; }


    public async Task Submit()
    {
        try
        {
            var result = await ClinicService.Insert(ModelDto);
            if (result)
            {
                ModelDto = new ClinicAddDto();

                ToastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }
}