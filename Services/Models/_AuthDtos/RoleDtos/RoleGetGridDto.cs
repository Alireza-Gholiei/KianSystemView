namespace Services.Models._AuthDtos.RoleDtos;

public class RoleGetGridDto
{
    public long Id { get; set; }
    public bool AccessAll { get; set; }
    public string Name { get; set; } = null!;
    public int UserRolesCount { get; set; }
    public string RoleParentName { get; set; } = null!;
    public int RoleChildrenCount { get; set; }
}