namespace Services.Models._AuthDtos.SSODtos;

public class LoginResultDto
{
    public string AccessToken { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
    public int ExpireRefreshToken { get; set; }
}