namespace Services.Models.StartDtos;

public class TrafficStatusDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public int DayExit { get; set; }
    public int HoursExit { get; set; }
    public int MinExit { get; set; }
    public int DayPresence { get; set; }
    public int HoursPresence { get; set; }
    public int MinPresence { get; set; }
    public int DayPresenceVacation { get; set; }
    public string? Closed { get; set; }
    public int DayRest { get; set; }
    public int DayExitVac { get; set; }
}