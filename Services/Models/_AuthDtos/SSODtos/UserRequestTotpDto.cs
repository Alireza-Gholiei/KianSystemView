namespace Services.Models._AuthDtos.SSODtos;

public class UserRequestTotpDto
{
    public string PhoneNumber { get; set; } = null!;
    public int ExpireSecond { get; set; }
    public string SecretKey { get; set; } = null!;
}