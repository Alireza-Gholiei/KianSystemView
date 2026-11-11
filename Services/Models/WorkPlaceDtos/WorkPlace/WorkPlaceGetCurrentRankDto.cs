namespace Services.Models.WorkPlaceDtos.WorkPlace;

public class WorkPlaceGetCurrentRankDto
{
    public long EmployeId { get; set; }
    public long RankId { get; set; }
    public long SectionId { get; set; }
    public string RankName { get; set; } = null!;
    public string SectionName { get; set; } = null!;
    public long PositionId { get; set; }
    public string PositionName { get; set; } = null!;
}