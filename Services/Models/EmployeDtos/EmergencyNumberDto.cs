using Services.Models.EmployeDtos.EmployeComplementDtos;
using System.ComponentModel.DataAnnotations;

namespace Services.Models.EmployeDtos;

public class EmergencyNumberDto
{
    public long Id { get; set; }
    [Display(Name = "عنوان"), Required(ErrorMessage = "{0} الزامی است")]
    public string Name { get; set; } = null!;
    [Display(Name = "شماره تماس"), Required(ErrorMessage = "{0} الزامی است")]
    public string PhoneNumber { get; set; } = null!;
    public long EmployeComplementId { get; set; }
    public AddEmployeComplementDto? EmployeComplement { get; set; }
}