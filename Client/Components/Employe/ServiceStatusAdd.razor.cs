using Mapster;
using Microsoft.AspNetCore.Components;
using Services.Models.EmployeDtos;
using Services.Models.EmployeDtos.Employe;
using Services.Models.EmployeDtos.ServiceStatusDtos;
using Services.Repositories.Interface.IEmploye;
using Services.Repositories.Interface.IStart;

namespace Client.Components.Employe;

public partial class ServiceStatusAdd : BaseComponent
{
    [Parameter] public long EmployeId { get; set; }

    [Inject] private IModalService ModalService { get; set; }
    [Inject] private IToastService ToastService { get; set; }
    [Inject] private IServiceStatusTypeService StatusTypeService { get; set; }
    [Inject] private IEscapeService EscapeService { get; set; }
    [Inject] private IEmployeService EmployeService { get; set; }
    [Inject] private IServiceStatusService ServiceStatusService { get; set; }

    private GetEmployeDto EmployeModel { get; set; } = new();
    public AddServiceStatusDto ServiceStatusDto { get; set; } = new AddServiceStatusDto();
    private List<ServiceStatusTypeDto> StatusTypeDtos { get; set; } = new List<ServiceStatusTypeDto>();
    private bool IsDateAbsence { get; set; } = false;
    private bool IsDateRun { get; set; } = false;
    private bool IsDateBack { get; set; } = false;
    private int DateAbsenceDefault { get; set; } = 0;
    private bool Submited { get; set; }

    protected override async Task OnInitializedAsync()
    {
        StatusTypeDtos = await StatusTypeService.GetAll();

        DateAbsenceDefault = (await EscapeService.GetFirst()).EscapeLength;

        EmployeModel = await EmployeService.GetById(EmployeId);

        var lastServiseStatus = await ServiceStatusService.GetLastServiseStatus(EmployeId);

        ServiceStatusDto = lastServiseStatus is not null ? lastServiseStatus.Adapt<AddServiceStatusDto>() : new AddServiceStatusDto();

        ServiceStatusDto.EmployeId = EmployeModel.Id;

        StatusChange();
    }

    private async Task Submit()
    {
        Submited = true;
        var result = await ServiceStatusService.Insert(ServiceStatusDto);
        if (result)
        {
            Submited = false;
            ModalService.Close();
        }
    }

    private void StatusChange()
    {
        if (ServiceStatusDto.ServiceStatusTypeId == 2)
        {
            IsDateAbsence = true;
            IsDateRun = true;
            ServiceStatusDto.DateAbsence = DateTime.Now;
        }
        else if (ServiceStatusDto.ServiceStatusTypeId == 3)
        {
            IsDateAbsence = true;
            ServiceStatusDto.DateAbsence = DateTime.Now;
        }
        else
        {
            ServiceStatusDto.DateAbsence = null;
            ServiceStatusDto.DateRun = null;
            ServiceStatusDto.DateBack = null;
        }
    }

    private void DateAbsenceChange()
    {
        if (ServiceStatusDto.ServiceStatusTypeId == 2)
        {
            ServiceStatusDto.DateRun = ServiceStatusDto.DateAbsence.GetValueOrDefault(new DateTime())
                .AddDays(DateAbsenceDefault);
        }
    }
}