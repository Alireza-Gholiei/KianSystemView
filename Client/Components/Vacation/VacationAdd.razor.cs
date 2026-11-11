using Microsoft.AspNetCore.Components;
using Services.Models.StartDtos;
using Services.Models.VacationDtos.Vacation;
using Services.Models.VacationDtos.VacationDetail;
using Services.Repositories.Interface.IStart;
using Services.Repositories.Interface.IVacation;

namespace Client.Components.Vacation;

public partial class VacationAdd : BaseComponent
{
    [Inject] private IVacationTypeService VacationTypeService { get; set; }
    [Inject] private IVacationService VacationService { get; set; }
    [Inject] private IToastService ToastService { get; set; }

    public VacationAddDto VacationAddDto { get; set; } = new VacationAddDto();
    public List<VacationTypeDto> VacationTypeList { get; set; } = new List<VacationTypeDto>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            VacationTypeList = await VacationTypeService.GetAll();

            VacationAddDto.VacationDetail.Add(new VacationDetailAddDto());
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void UpdateStartDate()
    {
        Calculator();
    }

    private void UpdateEndDate(VacationDetailAddDto model, double value)
    {
        try
        {
            model.Amount = value;
            Calculator();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void Calculator()
    {
        try
        {
            if (VacationAddDto.StartDateVacation != null && VacationAddDto.StartDateVacation != 0)
            {
                var staetDateTime = new DateTime(VacationAddDto.StartDateVacation);

                var sumAmount = VacationAddDto.VacationDetail.Sum(x => x.Amount) - 1;

                var endDate = staetDateTime.AddDays(sumAmount);

                VacationAddDto.EndDateVacation = endDate.Ticks;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    private void AddNewDetailRow()
    {
        try
        {
            VacationAddDto.VacationDetail.Add(new VacationDetailAddDto());
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    private void DeleteDetailRow(VacationDetailAddDto model)
    {
        try
        {
            if (VacationAddDto.VacationDetail.Count > 1)
            {
                VacationAddDto.VacationDetail.Remove(model);
            }
            else
            {
                ToastService.WarningAlert("این عملیات قابل انجام نیست");
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public async Task Submit()
    {
        try
        {
            var result = await VacationService.Insert(VacationAddDto);
            if (result)
            {
                VacationAddDto = new VacationAddDto();
                VacationAddDto.VacationDetail.Add(new VacationDetailAddDto());
                ToastService.SuccessAlert();
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlert(e.Message);
        }
    }
}