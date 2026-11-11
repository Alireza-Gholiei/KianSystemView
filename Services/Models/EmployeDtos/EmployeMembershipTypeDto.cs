namespace Services.Models.EmployeDtos;

public class EmployeMembershipTypeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;

    public List<DegreeTypeDto>? DegreeTypes { get; set; }
}