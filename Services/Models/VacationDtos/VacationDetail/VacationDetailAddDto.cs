using System.ComponentModel.DataAnnotations;

namespace Services.Models.VacationDtos.VacationDetail;

public class VacationDetailAddDto
{
    [Display(Name = "نوع مرخصی"), Required(ErrorMessage = "{0} الزامی است")]
    public long VacationTypeId { get; set; }
    [Display(Name = "مقدار مرخصی"), Required(ErrorMessage = "{0} الزامی است")]
    public double Amount { get; set; }
}