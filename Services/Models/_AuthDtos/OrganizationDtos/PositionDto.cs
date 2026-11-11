namespace Services.Models._AuthDtos.OrganizationDtos;

public class PositionDto
{
    public long Id { get; set; }
    public long SectionId { get; set; }
    public string PositionName { get; set; } = null!;
    public string? PositionDescription { get; set; }

    public SectionDto Section { get; set; } = null!;
}