using Storebook.Workflow.Service.WorkflowBaseDtos.InstanceDto;
using System.ComponentModel.DataAnnotations;

namespace Services.Models.WorkPlaceDtos.WorkPlace;

public class WorkPlaceNextInstanceDto : InsertNextInstanceDto
{
    public long WorkPlaceId { get; set; }
    [Display(Name = "واحد"), Required(ErrorMessage = "{0} الزامی است")]
    public long? PositionId { get; set; }
    [Display(Name = "شماره نامه"), Required(ErrorMessage = "{0} الزامی است")]
    public string? LetterNumber { get; set; }
}