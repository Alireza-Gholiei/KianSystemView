using Despro.Blazor.Modal.ModalGenerals;
using Microsoft.AspNetCore.Components;
using Services.Models.EmployeDtos;
using Services.Models.EmployeDtos.Employe;

namespace Client.Components.Employe;

public partial class EmergencyNumberAdd : BaseComponent
{
    [Parameter] public GetEmployeDto EmployeModel { get; set; }
    [Parameter] public List<EmergencyNumberDto> EmergencyNumberModel { get; set; } = new List<EmergencyNumberDto>();

    [Inject] private IModalService ModalService { get; set; }
    [Inject] private IToastService ToastService { get; set; }

    protected override Task OnInitializedAsync()
    {
        if (!EmergencyNumberModel.Any())
        {
            EmergencyNumberModel.Add(new EmergencyNumberDto());
        }

        return base.OnInitializedAsync();
    }

    private void Submit()
    {
        ModalService.Close(ModalResult.Ok(EmergencyNumberModel));
    }

    private void AddNewRow()
    {
        if (EmergencyNumberModel.Count < 5)
        {
            EmergencyNumberModel.Add(new EmergencyNumberDto());
        }
        else
        {
            ToastService.WarningAlert("این عملیات ممکن نیست");
        }
    }

    private void RemoveRow(EmergencyNumberDto model)
    {
        if (EmergencyNumberModel.Count > 1)
        {
            EmergencyNumberModel.Remove(model);
        }
        else
        {
            ToastService.WarningAlert("این عملیات ممکن نیست");
        }
    }
}