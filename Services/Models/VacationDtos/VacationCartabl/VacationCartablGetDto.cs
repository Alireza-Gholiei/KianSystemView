using Storebook.Workflow.Service.WorkflowBaseDtos.BaseModels;

namespace Services.Models.VacationDtos.VacationCartabl;

public class VacationCartablGetDto : BaseCartablGet
{
    public long VacationId { get; set; }
    public string EmployeName { get; set; } = null!;
    public string VacationAmount { get; set; } = null!;
    public long VacationStartDate { get; set; }
    public long VacationEndDate { get; set; }
    public string VacationType { get; set; } = null!;
}