using Storebook.Workflow.Service.WorkflowBaseDtos.BaseModels;

namespace Services.Models.WorkPlaceDtos.WorkPlace;

public class WorkPlaceGetCartableDto : BaseCartablGet
{
    public long WorkPlaceId { get; set; }
    public string EmployeName { get; set; } = null!;
    public string LetterNumber { get; set; } = null!;
    public string? Description { get; set; }
}