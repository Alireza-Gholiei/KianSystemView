namespace Services.Models._AuthDtos.UserDtos;

public class UserAddToRoleDto
{
    public long UserId { get; set; }
    public long RoleId { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}