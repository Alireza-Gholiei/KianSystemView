using Despro.Blazor.Display.Components.TreeViews;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.FormDtos;
using Services.Repositories.Interface._IAuth;

namespace Client.Components.Auth.Role;

public partial class RoleFormSelector : BaseComponent
{
    [Inject] private IFormService FormService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;

    [Parameter] public List<long> SelectedId { get; set; } = [];
    [Parameter] public EventCallback<List<long>> SelectedIdChanged { get; set; }

    public List<FormGetChildDto> Selected { get; set; } = [];

    private TreeView<FormGetChildDto> _roleTreeView { get; set; }
    private List<FormGetChildDto> Forms { get; set; } = [];
    private List<long> _selectedIds { get; set; } = [];

    protected override async Task OnInitializedAsync()
    {
        Forms = await FormService.GetChild();
        if (Forms.Any(x => SelectedId.Any(c => c == x.Id)))
        {
            Selected.AddRange(Forms.Where(x => SelectedId.Any(c => c == x.Id)).ToList());
        }

        _selectedIds = SelectedId;
    }

    private async Task<IList<FormGetChildDto>> GetSub(FormGetChildDto model)
    {
        var list = await FormService.GetChild(model.Id);

        if (list.Any(x => _selectedIds.Any(c => c == x.Id) && Selected.All(z => z.Id != x.Id)))
        {
            Selected.AddRange(list.Where(x => SelectedId.Any(c => c == x.Id)).ToList());
        }

        return list;
    }

    private Task OnSelectedChanges(List<FormGetChildDto> model)
    {
        if (model.Any(x => x.FormType == FormType.Menu))
        {
            ToastService.WarningAlertToast("امکان انتخاب منو ها وجود ندارم لطفا صفحات را انتخاب کنید");

            Selected = model.Where(x => x.FormType != FormType.Menu).ToList();

            SelectedId = model.Where(x => x.FormType != FormType.Menu).Select(x => x.Id).ToList();
            SelectedIdChanged.InvokeAsync(SelectedId);

            return Task.CompletedTask;
        }

        Selected = model;

        SelectedId = model.Select(x => x.Id).ToList();
        SelectedIdChanged.InvokeAsync(SelectedId);

        return Task.CompletedTask;
    }
}