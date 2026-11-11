using Services.Models.EmployeDtos.EmployeComplementDtos;

namespace Services.Models.EmployeDtos;

public class DegreeTypeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public byte Order { get; set; }
    public long MembershipTypeId { get; set; } //نوع عضویت
    public List<AddEmployeComplementDto>? EmployeComplements { get; set; }
    public EmployeMembershipTypeDto? EmployeMembershipType { get; set; }
}