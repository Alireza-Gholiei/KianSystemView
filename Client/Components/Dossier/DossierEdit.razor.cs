using Microsoft.AspNetCore.Components;
using Services.Models.DossierDtos;
using Services.Models.StartDtos.DossierListDtos;
using Services.Repositories.Interface.IDossier;
using Services.Repositories.Interface.IStart;

namespace Client.Components.Dossier;

public partial class DossierEdit : BaseComponent
{
    private DossierEditDto DossierDto { get; set; } = new();
    private List<DossierGetUploadedDto> DossierListDtos { get; set; } = [];

    [Inject] private IDossierService DossierService { get; set; } = null!;
    [Inject] private IDossierListService DossierListService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;

    private async Task Submit()
    {
        try
        {
            var result = await DossierService.Update(DossierDto);

            if (result)
            {
                DossierDto = new DossierEditDto();
                DossierListDtos = [];
                ToastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            DossierListDtos = [];
            ToastService.ErrorAlert(e.Message);
        }
    }

    private async Task EmployeSelect(long employeId)
    {
        try
        {
            DossierDto.EmployeId = employeId;

            DossierListDtos = await DossierListService.GetUploaded(employeId);
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }
}