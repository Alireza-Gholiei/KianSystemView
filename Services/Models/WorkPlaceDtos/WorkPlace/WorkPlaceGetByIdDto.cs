namespace Services.Models.WorkPlaceDtos.WorkPlace;

public class WorkPlaceGetByIdDto
{
    public long Id { get; set; }
    public long EmployeId { get; set; }
    public string EmployeName { get; set; } = null!;
    public long RankId { get; set; }
    public string RankName { get; set; } = null!;
    public long ActiveRankId { get; set; }
    public string ActiveRankName { get; set; } = null!;
    public string StatusName { get; set; } = null!;
    public string LetterNumber { get; set; } = null!;
    public string Description { get; set; } = null!;
}