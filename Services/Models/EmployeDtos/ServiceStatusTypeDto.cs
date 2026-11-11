using Services.Models.EmployeDtos.ServiceStatusDtos;

namespace Services.Models.EmployeDtos;

public class ServiceStatusTypeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;

    public List<AddServiceStatusDto>? StatusEntities { get; set; }
}