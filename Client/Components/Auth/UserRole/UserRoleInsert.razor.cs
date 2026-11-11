using Client.Components.Auth.Role;
using Despro.Blazor.Modal.ModalGenerals;
using Microsoft.AspNetCore.Components;
using Services.Models._AuthDtos.RoleDtos;
using Services.Models._AuthDtos.UserDtos;
using Services.Repositories.Interface._IAuth.IRole;
using Services.Repositories.Interface._IAuth.ISSO;

namespace Client.Components.Auth.UserRole;

public partial class UserRoleInsert : BaseComponent
{
    [Inject] private IRoleService RoleService { get; set; } = null!;
    [Inject] private IUserService UserService { get; set; } = null!;
    [Inject] private IModalService ModalService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;

    private UserAddToRoleDto UserRoleDto { get; set; } = new UserAddToRoleDto();
    private RoleGetChildDto ParentRole { get; set; } = new RoleGetChildDto();

    public async Task Submit()
    {
        try
        {
            var result = await UserService.AddToRole(UserRoleDto);
            if (result)
            {
                UserRoleDto = new UserAddToRoleDto();
                ParentRole = new RoleGetChildDto();
                ToastService.SuccessAlertToast("عملیات با موفقیت انجام شد لطفا به کاربر اطلاع دهید از حساب خود خارج و مجددا وارد شود", 0);
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

            component.Set(x => x.Selected, UserRoleDto.RoleId);

            var modalOptions = new ModalOptions
            {
                CloseOnClickOutside = false,
                ShowCloseButton = false,
                CloseOnEsc = false
            };

            var result = await ModalService.ShowAsync("انتخاب نقش", component, modalOptions);

            if (result.Data is RoleGetChildDto role)
            {
                UserRoleDto.RoleId = role.Id;
                ParentRole = role;
            }
        }
        catch (Exception e)
        {
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    private async Task MobileChange(string phone)
    {
        UserRoleDto.PhoneNumber = phone;
        if (phone is { Length: 11 })
        {
            var user = await UserService.GetDetailByPhone(phone);
            if (user != null)
            {
                UserRoleDto.UserId = user.Id;
                UserRoleDto.FirstName = user.FirstName;
                UserRoleDto.LastName = user.LastName;
            }
            else
            {
                ToastService.WarningAlertToast("کابری با این مشخصات در سایت ثبت نام نشده است لطفا اطلاعات را کامل کنید");
            }
        }
    }
}