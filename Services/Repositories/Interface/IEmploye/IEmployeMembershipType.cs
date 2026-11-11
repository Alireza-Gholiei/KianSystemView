using Services.Models.EmployeDtos;

namespace Services.Repositories.Interface.IEmploye;

public interface IEmployeMembershipType
{
    Task<List<EmployeMembershipTypeDto>> GetAll();
}