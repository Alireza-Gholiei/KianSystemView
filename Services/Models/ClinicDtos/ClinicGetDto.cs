using Services.Models.EmployeDtos.Employe;

namespace Services.Models.ClinicDtos;

public class ClinicGetDto
{
    public long Id { get; set; }
    public long EmployeId { get; set; }
    public string DoctorName { get; set; } = null!;
    public string NurseName { get; set; } = null!;
    /// <summary>
    /// اقلام و دارو مصرف
    /// </summary>
    public string ConsumableItems { get; set; } = null!;
    /// <summary>
    /// علت مراجعه
    /// </summary>
    public string ReasonReferral { get; set; } = null!;
    public DateTime EndTime { get; set; }
    /// <summary>
    /// تاریخ و ساعت مراجعه
    /// </summary>
    public long ReferralDate { get; set; }
    public string? Description { get; set; }
    public GetEmployeDto EmployeDto { get; set; } = null!;
}