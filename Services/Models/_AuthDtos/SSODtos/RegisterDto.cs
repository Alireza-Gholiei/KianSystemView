using System.ComponentModel.DataAnnotations;

namespace Services.Models._AuthDtos.SSODtos;

public class RegisterDto
{
    [Display(Name = "نام"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string FirstName { get; set; } = null!;
    [Display(Name = "نام خانوادگی"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string LastName { get; set; } = null!;
    [Display(Name = "نام کاربری(کدملی)"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string UserName { get; set; } = null!;
    [StringLength(100, MinimumLength = 8, ErrorMessage = "رمز عبور باید حداقل 8 کاراکتر باشد")]
    [Display(Name = "رمز عبور"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string Password { get; set; } = null!;
    [Compare(nameof(Password), ErrorMessage = "رمز عبور و تأیید آن مطابقت ندارند")]
    [Display(Name = "تائید رمز عبور"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string ConfirmPassword { get; set; } = null!;
    [Display(Name = "یگان خدمتی"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public long GarrisonId { get; set; }
    [Display(Name = "عضویت"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public long MemberShipTypeId { get; set; }
}