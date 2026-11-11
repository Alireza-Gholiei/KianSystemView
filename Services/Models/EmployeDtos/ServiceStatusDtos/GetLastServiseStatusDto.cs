namespace Services.Models.EmployeDtos.ServiceStatusDtos;

public class GetLastServiseStatusDto
{
    public long EmployeId { get; set; }
    public long ServiceStatusTypeId { get; set; }
    public DateTime? DateAbsence { get; set; }
    public DateTime? DateRun { get; set; }
    public DateTime? DateBack { get; set; }
    public long? VacationId { get; set; }
    public long? TrafficId { get; set; }
    public long? OnWorkId { get; set; }
}