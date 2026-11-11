namespace Services.Models.VacationDtos.Vacation;

public class VacationGetDto
{
    public long EmployeId { get; set; }
    public string VacationNumber { get; set; } = null!;
    public string VacationType { get; set; } = null!;
    public string VacationAmount { get; set; } = null!;
    public string StateName { get; set; } = null!;
    public long StartDateVacation { get; set; }
    public long EndDateVacation { get; set; }
    public long? StartDateTraffic { get; set; }
    public long? EndDateTraffic { get; set; }
    public string DeputyName { get; set; } = null!;
    public string Cause { get; set; } = null!;
    public string Description { get; set; } = null!;
}