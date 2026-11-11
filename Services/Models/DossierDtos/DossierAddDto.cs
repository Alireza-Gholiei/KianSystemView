using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace Services.Models.DossierDtos;

public class DossierAddDto
{
    [Display(Name = "سرباز"), Required(ErrorMessage = "{0} الزامی است")]
    public long EmployeId { get; set; }
    [Display(Name = "نوع سند"), Required(ErrorMessage = "{0} الزامی است")]
    public long DossierListId { get; set; }
    [Display(Name = "تصویر پرونده"), Required(ErrorMessage = "{0} الزامی است")]
    public IBrowserFile Dossier { get; set; } = null!;
}