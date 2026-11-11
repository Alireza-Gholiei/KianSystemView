namespace Services.Models._AuthDtos.OrganizationDtos;

public class SectionDto
{
    public long Id { get; set; }
    public string SectionName { get; set; } = null!;
    public string SectionCode { get; set; } = null!;
    public string? SectionDescription { get; set; }


    public List<PositionDto> Positions { get; set; } = null!;
}