using Services.Models._AuthDtos.PositionDtos;

namespace Services.Repositories.Interface._IAuth.IPosition;

public interface IPositionService
{
    Task<List<PositionGetSectionHeadPositions>> GetSectionHeadPositions();
}