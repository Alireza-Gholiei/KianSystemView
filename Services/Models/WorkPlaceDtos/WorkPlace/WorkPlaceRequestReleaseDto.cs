using System.ComponentModel.DataAnnotations;

namespace Services.Models.WorkPlaceDtos.WorkPlace;

public class WorkPlaceRequestReleaseDto
{
    public long EmployeId { get; set; }
    [Display(Name = "شماره نامه"), Required(ErrorMessage = "{0} الزامی است")]
    public string LetterNumber { get; set; } = null!;
    [Display(Name = "توضیحات")]
    public string? Description { get; set; }
}