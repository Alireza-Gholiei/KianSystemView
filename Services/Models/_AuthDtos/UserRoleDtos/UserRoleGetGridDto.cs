namespace Services.Models._AuthDtos.UserRoleDtos;

public class UserRoleGetGridDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public string UserFullName { get; set; } = null!;
    public long RoleId { get; set; }
    public string RoleName { get; set; } = null!;
}