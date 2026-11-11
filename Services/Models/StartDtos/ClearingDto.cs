namespace Services.Models.StartDtos;

public class ClearingDto
{
    public long Id { get; set; }
    public string ClearingName { get; set; } = null!;
    public string Sort { get; set; } = null!;
}