namespace Services.Models.EmployeDtos;

public class TrafficLoginTypeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;

    public List<OnWorkEmployeDto>? OnWorkEmployes { get; set; }
}