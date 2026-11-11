using System.ComponentModel.DataAnnotations;

namespace Services.Models._AuthDtos.SSODtos;

public class LoginDto
{
    [Display(Name = "نام کاربری(کدملی)"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string UserName { get; set; } = null!;
    [Display(Name = "رمز عبور"), Required(ErrorMessage = "فیلد {0} الزامی است")]
    public string Password { get; set; } = null!;
}