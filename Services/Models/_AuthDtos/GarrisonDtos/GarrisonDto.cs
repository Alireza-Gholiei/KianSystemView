namespace Services.Models._AuthDtos.GarrisonDtos;

public class GarrisonDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Code { get; set; } = null!;
}