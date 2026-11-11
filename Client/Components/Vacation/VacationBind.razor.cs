using Despro.Blazor.Base.Models;
using Microsoft.AspNetCore.Components;
using Services.Models.VacationDtos.Vacation;
using Services.Repositories.Interface.IVacation;

namespace Client.Components.Vacation;

public partial class VacationBind : BaseComponent
{
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private IVacationService _vacationService { get; set; }

    private GridData<VacationGetDto> _vacationGetDto { get; set; } = new GridData<VacationGetDto>();
    private long EmployeId { get; set; }
    private readonly BaseGrid _baseGrid = new BaseGrid();
    private bool _isBindGrid;

    public async Task OnBind(BaseGrid baseGrid)
    {
        try
        {
            if (_isBindGrid)
            {
                _vacationGetDto = await _vacationService.BindGrid(baseGrid);
            }
            else
            {
                _vacationGetDto = new GridData<VacationGetDto>();
            }
        }
        catch (Exception e)
        {
            _toastService.ErrorAlert(e.Message);
        }
    }

    private async Task EmployeSelect(long value)
    {
        try
        {
            if (_baseGrid.FilterParam.Any(x => x.Key == "EmployeId"))
            {
                _baseGrid.FilterParam.Remove(_baseGrid.FilterParam.FirstOrDefault(x => x.Key == "EmployeId"));

                _baseGrid.FilterParam.Add(new FilterParam("EmployeId", value.ToString()));
            }
            else
            {
                _baseGrid.FilterParam.Add(new FilterParam("EmployeId", value.ToString()));
            }

            _isBindGrid = true;

            await OnBind(_baseGrid);
        }
        catch (Exception e)
        {
            _toastService.ErrorAlert(e.Message);
        }
    }
}