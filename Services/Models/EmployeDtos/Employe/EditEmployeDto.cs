using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace Services.Models.EmployeDtos.Employe;

public class EditEmployeDto
{
    public long Id { get; set; }
    /// <summary>
    /// عکس
    /// </summary>
    [Display(Name = "عکس"), Required(ErrorMessage = "{0} الزامی است")]
    public IBrowserFile? PhotoFile { get; set; }
    /// <summary>
    /// نام
    /// </summary>
    [Display(Name = "نام"), Required(ErrorMessage = "{0} الزامی است")]
    public string FirstName { get; set; } = null!;
    /// <summary>
    /// نام خانوادگی
    /// </summary>
    [Display(Name = "نام خانوادگی"), Required(ErrorMessage = "{0} الزامی است")]
    public string LastName { get; set; } = null!;
    /// <summary>
    /// نام پدر
    /// </summary>
    [Display(Name = "نام پدر"), Required(ErrorMessage = "{0} الزامی است")]
    public string FatherName { get; set; } = null!;
    /// <summary>
    /// مدرک تحصیلی
    /// </summary>
    [Display(Name = "مدرک تحصیلی"), Required(ErrorMessage = "{0} الزامی است")]
    public long LevelEducationId { get; set; }
    /// <summary>
    /// شماره شناسنامه
    /// </summary>
    [Display(Name = "شماره شناسنامه"), Required(ErrorMessage = "{0} الزامی است")]
    public string BirthCertificate { get; set; } = null!;
    /// <summary>
    /// کدملی
    /// </summary>
    [Display(Name = "کدملی"), Required(ErrorMessage = "{0} الزامی است")]
    public string NationalCode { get; set; } = null!;
    /// <summary>
    /// تاریخ تولد
    /// </summary>
    [Display(Name = "تاریخ تولد"), Required(ErrorMessage = "{0} الزامی است")]
    public DateTime DateBirth { get; set; }
    /// <summary>
    /// رشته تحصیلی
    /// </summary>
    [Display(Name = "رشته تحصیلی"), Required(ErrorMessage = "{0} الزامی است")]
    public string FieldofStudy { get; set; } = null!;
    /// <summary>
    /// مهارت
    /// </summary>
    [Display(Name = "مهارت"), Required(ErrorMessage = "{0} الزامی است")]
    public string Proficiency { get; set; } = null!;
    /// <summary>
    /// تاریخ اعزام
    /// </summary>
    [Display(Name = "تاریخ اعزام"), Required(ErrorMessage = "{0} الزامی است")]
    public DateTime DayDispatch { get; set; }
    /// <summary>
    /// تاریخ معرفی به محل خدمت
    /// </summary>
    [Display(Name = "تاریخ معرفی به محل خدمت"), Required(ErrorMessage = "{0} الزامی است")]
    public DateTime DayIntroductionUnit { get; set; }
    /// <summary>
    /// شهرستان محل تولد
    /// </summary>
    [Display(Name = "شهرستان محل تولد"), Required(ErrorMessage = "{0} الزامی است")]
    public long CityPlaceofBirthId { get; set; }
    /// <summary>
    /// تاریخ ورود به محل خدمت
    /// </summary>
    [Display(Name = "تاریخ ورود به محل خدمت"), Required(ErrorMessage = "{0} الزامی است")]
    public DateTime DayLoginUnit { get; set; }
    /// <summary>
    /// استان محل تولد
    /// </summary>
    [Display(Name = "استان محل تولد"), Required(ErrorMessage = "{0} الزامی است")]
    public long CityAddressId { get; set; }
    /// <summary>
    /// آدرس محل سکونت
    /// </summary>
    [Display(Name = "آدرس محل سکونت"), Required(ErrorMessage = "{0} الزامی است")]
    public string Address { get; set; } = null!;
    /// <summary>
    /// شماره تماس فرد
    /// </summary>
    [Display(Name = "شماره تماس فرد"), Required(ErrorMessage = "{0} الزامی است")]
    public string PhoneNumber { get; set; } = null!;
    /// <summary>
    /// رسته خدمتی
    /// </summary>
    [Display(Name = "رسته خدمتی"), Required(ErrorMessage = "{0} الزامی است")]
    public long ServiceLineId { get; set; }
    /// <summary>
    /// توضیحات
    /// </summary>
    [Display(Name = "توضیحات")]
    public string? Description { get; set; }
}