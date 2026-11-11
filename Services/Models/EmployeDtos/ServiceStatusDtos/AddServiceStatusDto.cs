using System.ComponentModel.DataAnnotations;

namespace Services.Models.EmployeDtos.ServiceStatusDtos;

public class AddServiceStatusDto
{
    public long Id { get; set; }
    [Display(Name = "سرباز"), Required(ErrorMessage = "{0} الزامی است")]
    public long EmployeId { get; set; }
    [Display(Name = "وضعیت خدمتی"), Required(ErrorMessage = "{0} الزامی است")]
    public long ServiceStatusTypeId { get; set; }
    public DateTime? DateAbsence { get; set; }
    public DateTime? DateRun { get; set; }
    public DateTime? DateBack { get; set; }
    public long? VacationId { get; set; }
    public long? TrafficId { get; set; }
    public long? OnWorkId { get; set; }
}