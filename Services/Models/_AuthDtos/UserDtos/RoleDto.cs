namespace Services.Models._AuthDtos.UserDtos;

public class RoleDto
{
    public long Id { get; set; }
    public string ViewName { get; set; } = null!;
    public string RoleName { get; set; } = null!;
    public string HeaderName { get; set; } = null!;
}