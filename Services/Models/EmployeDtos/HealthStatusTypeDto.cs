using Services.Models.EmployeDtos.EmployeComplementDtos;

namespace Services.Models.EmployeDtos;

public class HealthStatusTypeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;

    public List<AddEmployeComplementDto>? EmployeComplements { get; set; }
}