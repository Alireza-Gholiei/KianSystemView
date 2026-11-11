using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;
using Services.Models.EmployeDtos.Employe;
using Services.Repositories.Interface.IEmploye;

namespace Client.Components._Shared;

public partial class EmployeDetail : BaseComponent
{
    [Parameter] public long EmployeId { get; set; }
    [Parameter] public EventCallback<long> EmployeIdChanged { get; set; }
    [Parameter] public Expression<Func<long>> EmployeIdExpression { get; set; }

    [Inject] private IModalService ModalService { get; set; }
    [Inject] private IEmployeService EmployeService { get; set; }

    private EmployeGetForDetailDto EmployeModel { get; set; } = new EmployeGetForDetailDto();
    private bool IsLodding { get; set; }

    private async Task SelectEmploye()
    {
        try
        {
            IsLodding = true;
            var component = new RenderComponent<EmployeSelectList>();

            var result = await ModalService.ShowAsync("انتخاب سرباز", component);

            if (result.Data is EmployeGetForDetailDto data)
            {
                EmployeModel = data;
                await EmployeIdChanged.InvokeAsync(data.Id);
            }
            IsLodding = false;
        }
        catch (Exception)
        {
            // ignored
        }
    }

    private async Task NationalCodeChange(string value)
    {
        try
        {
            EmployeModel.NationalCode = value;
        }
        catch (Exception)
        {
            // ignored
        }
    }

    private async Task OnInput(ChangeEventArgs e)
    {
        try
        {
            EmployeModel.NationalCode = e.Value.ToString();
            if (e.Value.ToString().Length == 10)
            {
                IsLodding = true;
                EmployeModel = await EmployeService.GetByNationalCodeForDetail(e.Value.ToString());
                await EmployeIdChanged.InvokeAsync(EmployeModel.Id);
                IsLodding = false;
            }
        }
        catch (Exception)
        {
            // ignored
        }
    }
}