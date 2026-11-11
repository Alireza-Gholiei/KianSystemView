using Microsoft.AspNetCore.Components;
using Services.Models.DossierDtos;
using Services.Models.StartDtos.DossierListDtos;
using Services.Repositories.Interface.IDossier;
using Services.Repositories.Interface.IStart;

namespace Client.Components.Dossier;

public partial class DossierAdd : BaseComponent
{
    private DossierAddDto DossierDto { get; set; } = new DossierAddDto();
    private List<DossierListDto> DossierListDtos { get; set; } = new List<DossierListDto>();

    [Inject] private IDossierService DossierService { get; set; }
    [Inject] private IDossierListService DossierListService { get; set; }
    [Inject] private IToastService ToastService { get; set; }

    public async Task Submit()
    {
        try
        {
            var result = await DossierService.Insert(DossierDto);

            if (result)
            {
                DossierDto = new DossierAddDto();
                DossierListDtos = new List<DossierListDto>();
                ToastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            DossierListDtos = new List<DossierListDto>();
            ToastService.ErrorAlert(e.Message);
        }
    }

    public async Task EmployeSelect(long employeId)
    {
        try
        {
            DossierDto.EmployeId = employeId;

            DossierListDtos = await DossierListService.GetNotUploaded(employeId);
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }
}