using Despro.Blazor.Modal.ModalGenerals;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.RoleDtos;
using Services.Repositories.Interface._IAuth.IRole;

namespace Client.Components.Auth.Role;

public partial class RoleInsert : BaseComponent
{
    [Inject] private IRoleService RoleService { get; set; } = null!;
    [Inject] private IModalService ModalService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;

    private RoleAddDto RoleDto { get; set; } = new RoleAddDto();
    private RoleGetChildDto ParentRole { get; set; } = new RoleGetChildDto();
    private RoleAddDto Forms { get; set; } = new RoleAddDto();


    public async Task Submit()
    {
        try
        {
            var result = await RoleService.Insert(RoleDto);
            if (result)
            {
                RoleDto = new RoleAddDto();
                ParentRole = new RoleGetChildDto();
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