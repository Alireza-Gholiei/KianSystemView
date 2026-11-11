using Services.Models._AuthDtos.UserDtos;

namespace Services.Models._AuthDtos.FormDtos;

public class RoleFormDto
{
    public long Id { get; set; }
    public long FormId { get; set; }
    public long RoleId { get; set; }

    public RoleDto Role { get; set; } = null!;
    public FormDto Form { get; set; } = null!;
}