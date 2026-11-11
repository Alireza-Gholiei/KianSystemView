using Mapster;
using Microsoft.AspNetCore.Components;
using Services.Models.ClinicDtos;
using Services.Repositories.Interface.IClinic;

namespace Client.Components.Clinic;

public partial class ClinicEdit : BaseComponent
{
    [Parameter] public long Id { get; set; }
    [Inject] private IToastService ToastService { get; set; } = null!;
    [Inject] private IClinicService ClinicService { get; set; } = null!;

    public ClinicGetDto ModelGteDto { get; set; } = new ClinicGetDto();
    public ClinicEditDto ModelEditDto { get; set; } = new ClinicEditDto();


    protected override async Task OnInitializedAsync()
    {
        try
        {
            var model = await ClinicService.GetById(Id);

            ModelEditDto = model.Adapt<ClinicEditDto>();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task Submit()
    {
        try
        {
            var result = await ClinicService.Update(ModelEditDto);
            if (result)
            {
                ModelEditDto = new ClinicEditDto();
                ToastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }
}