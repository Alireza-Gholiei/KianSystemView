using Services.Models.VacationDtos.VacationDetail;
using System.ComponentModel.DataAnnotations;

namespace Services.Models.VacationDtos.Vacation;

public class VacationAddDto
{
    public long EmployeId { get; set; }
    [Display(Name = "تاریخ شروع مرخصی"), Required(ErrorMessage = "{0} الزامی است")]
    public long StartDateVacation { get; set; }
    [Display(Name = "تاریخ پایان مرخصی"), Required(ErrorMessage = "{0} الزامی است")]
    public long EndDateVacation { get; set; }
    [Display(Name = "نام جانشین")]
    public string? DeputyName { get; set; }
    [Display(Name = "علت مرخصی")]
    public string? Cause { get; set; }
    [Display(Name = "توضیحات")]
    public string? Description { get; set; }

    public List<VacationDetailAddDto> VacationDetail { get; set; } = new List<VacationDetailAddDto>();
}