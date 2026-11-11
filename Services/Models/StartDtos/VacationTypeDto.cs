namespace Services.Models.StartDtos;

public class VacationTypeDto
{
    public long Id { get; set; }
    public string VacationName { get; set; } = null!;
    public string VacationLenghtType { get; set; } = null!;
    public double VacationLenght { get; set; }
}