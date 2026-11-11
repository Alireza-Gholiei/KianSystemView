namespace Services.Models.TrafficDtos;

public class TrafficResultRegisterDto
{
    public bool IsSuccsess { get; set; }
    public bool AllowedToLeave { get; set; }
    public string Message { get; set; } = null!;
    public long TrafficLoginTypeGKey { get; set; }
}