using Microsoft.AspNetCore.Components;
using Services.Models.TrafficDtos;
using Services.Repositories.Interface.ITraffic;

namespace Client.Components.Traffic;

public partial class ManualRegisterTraffic : BaseComponent
{
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private ITrafficService _trafficService { get; set; }

    private ManualRegisterTrafficIntertDto registerTrafficIntertDto { get; set; } = new ManualRegisterTrafficIntertDto();
    private long TrafficTime { get; set; }


    private async Task Submit()
    {
        try
        {
            registerTrafficIntertDto.TrafficDate = registerTrafficIntertDto.TrafficDate + TrafficTime;

            var result = await _trafficService.RegisterManual(registerTrafficIntertDto);

            if (result.IsSuccsess)
            {
                _toastService.SuccessAlert(result.Message);
            }
            else
            {
                _toastService.WarningAlert(result.Message);
            }
        }
        catch (Exception e)
        {
            _toastService.ErrorAlert(e.Message);
        }
    }
}
