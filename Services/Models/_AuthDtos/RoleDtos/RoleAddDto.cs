namespace Services.Models._AuthDtos.RoleDtos;

public class RoleAddDto
{
    public long ParentId { get; set; }
    public string Name { get; set; } = null!;
    public bool AccessAll { get; set; }
    public List<long> Forms { get; set; } = [];
}