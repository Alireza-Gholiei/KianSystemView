using Microsoft.AspNetCore.Components;
using Services.Models.TrafficDtos;
using Services.Repositories.Interface.ITraffic;

namespace Client.Components.Traffic;

public partial class RegisterTraffic : BaseComponent
{
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private ITrafficService _trafficService { get; set; }

    private RegisterTrafficIntertDto registerTrafficIntertDto { get; set; } = new RegisterTrafficIntertDto();

    private async Task Submit()
    {
        try
        {
            var result = await _trafficService.Register(registerTrafficIntertDto);

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
