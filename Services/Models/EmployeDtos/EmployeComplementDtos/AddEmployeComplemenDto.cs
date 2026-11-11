using System.ComponentModel.DataAnnotations;

namespace Services.Models.EmployeDtos.EmployeComplementDtos;

public class AddEmployeComplementDto
{
    public long Id { get; set; }
    [Display(Name = "سرباز"), Required(ErrorMessage = "{0} الزامی است")]
    public long EmployeId { get; set; }
    [Display(Name = "نوع سکونت"), Required(ErrorMessage = "{0} الزامی است")]
    public long ResidenceTypeId { get; set; }
    [Display(Name = "نوع تردد"), Required(ErrorMessage = "{0} الزامی است")]
    public long TrafficStatusId { get; set; }
    [Display(Name = "وضعیت خدمتی"), Required(ErrorMessage = "{0} الزامی است")]
    public long ServiceStatusId { get; set; } //وضعیت خدمتی
    [Display(Name = "درجه"), Required(ErrorMessage = "{0} الزامی است")]
    public long DegreeId { get; set; } //درجه
    [Display(Name = "وضعیت سلامت"), Required(ErrorMessage = "{0} الزامی است")]
    public long HealthStatusId { get; set; } //وضعیت سلامت
    [Display(Name = "کد پرسنلی"), Required(ErrorMessage = "{0} الزامی است")]
    public string PersonnelCode { get; set; } = null!; //کد پرسنلی
    [Display(Name = "اضافه خدمت سنواتی"), Required(ErrorMessage = "{0} الزامی است")]
    public int BackPunish { get; set; } //اضافه خدمت سنواتی
    /// <summary>
    /// True متاهل
    /// False مجرد
    /// </summary>
    [Display(Name = "وضعیت تاهل"), Required(ErrorMessage = "{0} الزامی است")]
    public bool MaritalStatus { get; set; }//وضعیت تاهل
    public int ChildCount { get; set; }//تعداد فرزندان


    [Display(Name = "شماره تماس های اضطراری"), Required(ErrorMessage = "{0} الزامی است")]
    public List<EmergencyNumberDto>? EmergencyNumbers { get; set; }
}