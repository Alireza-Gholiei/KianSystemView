namespace Services.Models._AuthDtos.RoleDtos;

public class RoleGetChildDto
{
    public long Id { get; set; }
    public long? ParentId { get; set; }
    public string Name { get; set; } = null!;
}