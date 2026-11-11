using System.ComponentModel;

namespace Services.Models.EmployeDtos;

public class ListEmployeDto
{
    public long Id { get; set; }
    [DisplayName("شماره پرونده")]
    public string DossierNumber { get; set; } = null!; //شماره پرونده
    [DisplayName("نام")]
    public string? FirstName { get; set; } //نام
    [DisplayName("نام خانوادگی")]
    public string? LastName { get; set; } //نام خانوادگی
    [DisplayName("نام پدر")]
    public string? FatherName { get; set; } // نام پدر
    [DisplayName("شماره شناسنامه")]
    public string? BirthCertificate { get; set; } //شماره شناسنامه
    [DisplayName("کدملی")]
    public string? NationalCode { get; set; } //کدملی
    [DisplayName("تاریخ تولد")]
    public string? DateBirth { get; set; } //تاریخ تولد
    [DisplayName("مدرک تحصیلات")]
    public string? LevelEducation { get; set; } //مدرک تحصیلات
    [DisplayName("رشته تحصیلی")]
    public string? FieldofStudy { get; set; } //رشته تحصیلی
    [DisplayName("تخصص")]
    public string? Proficiency { get; set; } //تخصص 
    [DisplayName("تاریخ اعزام")]
    public string? DayDispatch { get; set; } //تاریخ اعزام
    [DisplayName("تاریخ معرفی به رده")]
    public string? DayIntroductionUnit { get; set; } //تاریخ معرفی به رده
    [DisplayName("محل تولد")]
    public string? PlaceofBirth { get; set; } //محل تولد
    [DisplayName("آدرس محل سکونت")]
    public string? Address { get; set; }//آدرس محل سکونت
    [DisplayName("شماره تماس")]
    public string? PhoneNumber { get; set; }//شماره تماس
    [DisplayName("رسته خدمتی")]
    public string? ServiceLine { get; set; }//رسته خدمتی
    [DisplayName("توضیحات")]
    public string? Description { get; set; } //توضیحات
    [DisplayName("روز ثبت نام")]
    public string? DateRegister { get; set; } //روز ثبت نام
    [DisplayName("نوع سکونت")]
    public string? TrafficType { get; set; }
    [DisplayName("نوع تردد")]
    public string? TrafficStatus { get; set; }
    [DisplayName("کد پرسنلی")]
    public string? PersonnelCode { get; set; } //کد پرسنلی
    [DisplayName("وضعیت خدمتی")]
    public string? ServiceStatus { get; set; } //وضعیت خدمتی
    [DisplayName("شماره تماس اظطراری")]
    public string? EmergencyNumber { get; set; } // شماره تماس اظطراری
    [DisplayName("نوع عضویت")]
    public string? MembershipType { get; set; } //نوع عضویت
    [DisplayName("درجه")]
    public string? Degree { get; set; } //درجه
    [DisplayName("وضعیت سلامت")]
    public string? HealthStatus { get; set; } //وضعیت سلامت
    [DisplayName("اضافه خدمت سنواتی")]
    public int BackPunish { get; set; } //اضافه خدمت سنواتی
    [DisplayName("وضعیت تاهل")]
    public string? MaritalStatus { get; set; }//وضعیت تاهل
    [DisplayName("تعداد فرزندان")]
    public byte ChildCount { get; set; }//تعداد فرزندان
    [DisplayName("معاونت بکارگیری")]
    public string? Section { get; set; } //درجه
    [DisplayName("واحد بکارگیری")]
    public string? Unit { get; set; } //درجه
    [DisplayName("تاریخ ثبت اطلاعات تکمیلی")]
    public string? RegDate { get; set; }//تاریخ ثبت
}