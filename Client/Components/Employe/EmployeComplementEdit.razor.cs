using Microsoft.AspNetCore.Components;
using Services.Models.EmployeDtos;
using Services.Models.EmployeDtos.Employe;
using Services.Models.EmployeDtos.EmployeComplementDtos;
using Services.Models.StartDtos;
using Services.Repositories.Interface.IEmploye;
using Services.Repositories.Interface.IStart;

namespace Client.Components.Employe;

public partial class EmployeComplementEdit : BaseComponent
{
    [Parameter] public long EmployeId { get; set; }

    private EditEmployeComplementDto EmployeComplementModel { get; set; } = new();
    private GetEmployeDto EmployeModel { get; set; } = new();
    private List<DegreeTypeDto> DegreeTypeDtos { get; set; } = new();
    private List<HealthStatusTypeDto> HealthStatusTypeDtos { get; set; } = new();
    private List<TrafficStatusDto> TrafficStatusDtos { get; set; } = new();
    private List<ResidenceTypeDto> ResidenceTypeDtos { get; set; } = new();
    private List<MaritalStatusDto> MaritalStatusDtos { get; set; } = new();
    private bool Submited { get; set; }


    [Inject] private IEmployeComplementService ComplemenService { get; set; }
    [Inject] private IEmployeService EmployeService { get; set; }
    [Inject] private IDegreeTypeService DegreeTypeService { get; set; }
    [Inject] private IHealthStatusTypeService HealthStatusTypeService { get; set; }
    [Inject] private ITrafficStatusService TrafficStatusService { get; set; }
    [Inject] private IResidenceTypeService ResidenceTypeService { get; set; }
    [Inject] private IToastService ToastService { get; set; }
    [Inject] private IModalService ModalService { get; set; }


    protected override async Task OnInitializedAsync()
    {
        try
        {
            DegreeTypeDtos = await DegreeTypeService.GetAll();
            HealthStatusTypeDtos = await HealthStatusTypeService.GetAll();
            TrafficStatusDtos = await TrafficStatusService.GetAll();
            ResidenceTypeDtos = await ResidenceTypeService.GetAll();

            MaritalStatusDtos =
            [
                new MaritalStatusDto() { MaritalStatusType = false, MaritalStatusName = "مجرد" },
                new MaritalStatusDto() { MaritalStatusType = true, MaritalStatusName = "متاهل" }
            ];

            EmployeModel = await EmployeService.GetById(EmployeId);

            EmployeComplementModel = await ComplemenService.GetByEmployeId(EmployeId);
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }

    private async Task Submit()
    {
        try
        {
            Submited = true;
            var result = await ComplemenService.Update(EmployeComplementModel);
            if (result)
            {
                Submited = false;
                ModalService.Close();
            }
        }
        catch (Exception e)
        {
            Submited = false;
            ToastService.ErrorAlert(e.Message);
        }
    }

    private async Task EmergencyModal()
    {
        try
        {
            var component = new RenderComponent<EmergencyNumberAdd>();

            component.Set(x => x.EmployeModel, EmployeModel);

            if (EmployeComplementModel.EmergencyNumbers is not null)
            {
                component.Set(x => x.EmergencyNumberModel, EmployeComplementModel.EmergencyNumbers);
            }

            var result = await ModalService.ShowAsync("افزودن شماره تماس های اضطراری", component);

            if (result.Data is List<EmergencyNumberDto> data)
            {
                EmployeComplementModel.EmergencyNumbers = data;
            }
        }
        catch (Exception)
        {
            // ignored
        }
    }
}