using Services.Models._AuthDtos.OrganizationDtos;

namespace Services.Models._AuthDtos.UserDtos;

public class UserDto
{
    public long Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public bool AccessAll { get; set; }
    public bool AccessAllSoldier { get; set; }
    public long SectionId { get; set; }
    public long PositionId { get; set; }
    public string MemberShipType { get; set; } = null!;

    public ICollection<UserRoleDto>? UserRoles { get; set; }
    public PositionDto? Position { get; set; }
    public SectionDto? Section { get; set; }
}