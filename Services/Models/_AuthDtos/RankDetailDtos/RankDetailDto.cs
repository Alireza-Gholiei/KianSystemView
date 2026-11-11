namespace Services.Models._AuthDtos.RankDetailDtos;

public class RankDetailDto
{
    public long SectionId { get; set; }
    public string SectionName { get; set; } = null!;
    public long PositionId { get; set; }
    public string PositionName { get; set; } = null!;
    public long RankId { get; set; }
    public string RankName { get; set; } = null!;
}