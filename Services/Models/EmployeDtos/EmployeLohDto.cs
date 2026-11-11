namespace Services.Models.EmployeDtos;

public class EmployeLohDto
{
    public long Id { get; set; }
    public long? EmployeId { get; set; }
    public string? Name { get; set; }
    public int PostCount { get; set; }
}