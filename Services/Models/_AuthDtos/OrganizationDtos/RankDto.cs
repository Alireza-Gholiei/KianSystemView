namespace Services.Models._AuthDtos.OrganizationDtos;

public class RankDto
{
    public long Id { get; set; }
    public long SectionId { get; set; }
    public string RankName { get; set; } = null!;
    public string? RankDescription { get; set; }

    public SectionDto Section { get; set; } = null!;
}