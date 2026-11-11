using Despro.Blazor.Modal.ModalGenerals;
using Mapster;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.RoleDtos;
using Services.Repositories.Interface._IAuth.IRole;

namespace Client.Components.Auth.Role;

public partial class RoleUpdate : BaseComponent
{
    [Inject] private IRoleService RoleService { get; set; }
    [Inject] private IModalService ModalService { get; set; }
    [Inject] private IToastService ToastService { get; set; }

    [Parameter] public long Id { get; set; }

    private RoleEditDto RoleDto { get; set; } = new RoleEditDto();
    private RoleGetChildDto ParentRole { get; set; } = new RoleGetChildDto();

    protected override async Task OnInitializedAsync()
    {
        var model = await RoleService.GetById(Id);

        RoleDto = model.Adapt<RoleEditDto>();

        var modelParent = await RoleService.GetById(Id);

        ParentRole = modelParent.Adapt<RoleGetChildDto>();
    }

    public async Task Submit()
    {
        try
        {
            var result = await RoleService.Update(RoleDto);
            if (result)
            {
                ModalService.Close();
                ToastService.SuccessAlertToast();
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    private async Task SelectParent()
    {
        try
        {
            var component = new RenderComponent<RoleParentSelect>();

            component.Set(x => x.Selected, RoleDto.ParentId);

            var modalOptions = new ModalOptions
            {
                CloseOnClickOutside = false,
                ShowCloseButton = false,
                CloseOnEsc = false
            };

            var result = await ModalService.ShowAsync("انتخاب نقش بالا دست", component, modalOptions);

            if (result.Data is RoleGetChildDto role)
            {
                RoleDto.ParentId = role.Id;
                ParentRole = role;
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    private async Task SelectForm()
    {
        try
        {
            var component = new RenderComponent<RoleFormSelect>();

            component.Set(x => x.Selected, RoleDto.Forms);

            var modalOptions = new ModalOptions
            {
                CloseOnClickOutside = false,
                ShowCloseButton = false,
                CloseOnEsc = false
            };

            var result = await ModalService.ShowAsync("انتخاب فرم قابل دسترس", component, modalOptions);

            if (result.Data is List<long> ids)
            {
                RoleDto.Forms = ids;
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlertToast(e.Message);
        }
    }
}