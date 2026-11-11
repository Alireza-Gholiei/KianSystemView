namespace Services.Models.StartDtos;

public class ClosedDto
{
    public long Id { get; set; }
    public string ClosedName { get; set; } = null!;
    public DateTime ClosedDate { get; set; }
}