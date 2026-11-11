using Services.Models.EmployeDtos.Employe;

namespace Services.Models.EmployeDtos;

public class OnWorkEmployeDto
{
    public long Id { get; set; }
    public long EmployeId { get; private set; }
    public bool OnWork { get; private set; }
    public long LogDate { get; private set; }
    public long TrafficLoginTypeId { get; private set; }


    public AddEmployeDto? Employe { get; set; }

    public TrafficLoginTypeDto? TrafficLoginType { get; set; }
}