namespace Services.Models.EmployeDtos.Employe;

public class EmployeGetForDetailDto
{
    public long Id { get; set; }
    public string DossierNumber { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FatherName { get; set; } = null!;
    public string NationalCode { get; set; } = null!;
    public DateTime DateBirth { get; set; }
    public DateTime DayDispatch { get; set; }
}