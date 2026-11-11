namespace Services.Models.EmployeDtos.Employe;

public class EmployeSelect
{
    public long Id { get; set; }
    public string NationalCode { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}