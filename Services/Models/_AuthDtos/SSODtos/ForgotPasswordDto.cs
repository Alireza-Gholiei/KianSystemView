using System.ComponentModel.DataAnnotations;

namespace Services.Models._AuthDtos.SSODtos;

public class ForgotPasswordDto
{
    [Display(Name = "شماره تماس"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string PhoneNumber { get; set; } = null!;
    [Display(Name = "کد تائید"), Required(ErrorMessage = "فیلد {0} الزامی است"), MaxLength(6, ErrorMessage = "کد تأیید نمیتواند بیشتر 6 رقم باشد")]
    public string TotpCode { get; set; } = null!;
    [StringLength(100, MinimumLength = 8, ErrorMessage = "رمز عبور باید حداقل 8 کاراکتر باشد")]
    [Display(Name = "رمز عبور"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string Password { get; set; } = null!;
    [Compare(nameof(Password), ErrorMessage = "رمز عبور و تأیید آن مطابقت ندارند")]
    [Display(Name = "تائید رمز عبور"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string ConfirmPassword { get; set; } = null!;
    public string SecretKey { get; set; } = null!;
}