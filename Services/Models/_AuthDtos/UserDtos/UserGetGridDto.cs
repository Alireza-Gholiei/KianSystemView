namespace Services.Models._AuthDtos.UserDtos;

public class UserGetGridDto
{
    public string FullName { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string LockoutEnabled { get; set; } = null!;
    public string CreateDate { get; set; } = null!;
    public int OrderCount { get; set; }
    public int CartCount { get; set; }
}