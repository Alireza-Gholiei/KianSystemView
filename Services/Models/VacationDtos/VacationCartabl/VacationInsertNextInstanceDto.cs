using Storebook.Workflow.Service.WorkflowBaseDtos.InstanceDto;

namespace Services.Models.VacationDtos.VacationCartabl;

public class VacationInsertNextInstanceDto : InsertNextInstanceDto
{
    public long VacationId { get; set; }
}