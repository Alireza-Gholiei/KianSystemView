using Services.Models.EmployeDtos.Employe;

namespace Services.Models.ClinicDtos;

public class ClinicEditDto
{
    public long Id { get; set; }
    public long EmployeId { get; set; }
    public string DoctorName { get; set; } = string.Empty;
    public string NurseName { get; set; } = string.Empty;
    /// <summary>
    /// اقلام و دارو مصرف
    /// </summary>
    public string ConsumableItems { get; set; } = string.Empty;
    /// <summary>
    /// علت مراجعه
    /// </summary>
    public string ReasonReferral { get; set; } = string.Empty;
    public DateTime EndTime { get; set; }
    /// <summary>
    /// تاریخ و ساعت مراجعه
    /// </summary>
    public long ReferralDate { get; set; }
    public string? Description { get; set; }
    public GetEmployeDto EmployeDto { get; set; } = null!;
}