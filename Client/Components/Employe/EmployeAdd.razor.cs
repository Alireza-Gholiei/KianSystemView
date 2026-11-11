using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.LocationDtos;
using Services.Models.EmployeDtos;
using Services.Models.EmployeDtos.Employe;
using Services.Models.StartDtos;
using Services.Repositories.Interface._IAuth.ILocation;
using Services.Repositories.Interface.IEmploye;
using Services.Repositories.Interface.IStart;

namespace Client.Components.Employe;

public partial class EmployeAdd : BaseComponent
{
    private AddEmployeDto Employe { get; set; } = new AddEmployeDto();
    private LocationDto SelectedBirthProvince { get; set; } = new LocationDto();
    private LocationDto SelectedAddressProvince { get; set; } = new LocationDto();
    private List<LocationDto> ListProvincesAddress { get; set; } = [];
    private List<LocationDto> ListProvincesBirth { get; set; } = [];
    private List<LocationDto> ListCitiesAddress { get; set; } = [];
    private List<LocationDto> ListCitiesBirth { get; set; } = [];
    private List<EducationLevelDto> ListEducationLevel { get; set; } = [];
    private List<ServiceLineTypeDto> ListServiceLine { get; set; } = [];


    [Inject] private ILocationService LocationService { get; set; }
    [Inject] private IEducationLevelService EducationLevelService { get; set; }
    [Inject] private IServiceLineTypeService ServiceLineTypeService { get; set; }
    [Inject] private IEmployeService EmployeService { get; set; }
    [Inject] private IToastService ToastService { get; set; }


    protected override async Task OnInitializedAsync()
    {
        try
        {
            var listProvinces = await LocationService.GetProvince();

            ListProvincesAddress = listProvinces;
            ListProvincesBirth = listProvinces;

            ListEducationLevel = await EducationLevelService.GetAll();
            ListServiceLine = await ServiceLineTypeService.GetAll();

            await base.OnInitializedAsync();
        }
        catch (Exception)
        {
            ToastService.ErrorAlert();
        }
    }

    public async Task Submit()
    {
        try
        {
            var result = await EmployeService.Insert(Employe);
            if (result)
            {
                Employe = new AddEmployeDto();
                ListProvincesBirth = [];
                ListProvincesAddress = [];
                ToastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }

    private async Task BindCityBirth()
    {
        try
        {
            if (SelectedBirthProvince == null)
            {
                ListCitiesBirth = [];
                return;
            }

            var city = await LocationService.GetCityByProvince(SelectedBirthProvince.Id);
            ListCitiesBirth = city;
        }
        catch (Exception)
        {
            ToastService.ErrorAlert();
        }
    }

    private async Task BindCityAddress()
    {
        try
        {
            if (SelectedAddressProvince == null)
            {
                ListCitiesAddress = [];
                return;
            }

            var city = await LocationService.GetCityByProvince(SelectedAddressProvince.Id);
            ListCitiesAddress = city;
        }
        catch (Exception)
        {
            ToastService.ErrorAlert();
        }
    }
}