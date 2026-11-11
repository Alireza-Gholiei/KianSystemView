using Services.Models.EmployeDtos.Employe;

namespace Services.Models.EmployeDtos;

public class ServiceLineTypeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;

    public List<AddEmployeDto>? Employes { get; set; }
}