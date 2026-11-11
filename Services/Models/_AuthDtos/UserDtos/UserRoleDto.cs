namespace Services.Models._AuthDtos.UserDtos;

public class UserRoleDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long RoleId { get; set; }
    public string RoleName { get; set; } = null!;
}