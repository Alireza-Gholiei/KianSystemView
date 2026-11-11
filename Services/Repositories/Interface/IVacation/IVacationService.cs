using Despro.Blazor.Base.Models;
using Services.Models.VacationDtos.Vacation;
using Services.Models.VacationDtos.VacationCartabl;

namespace Services.Repositories.Interface.IVacation;

public interface IVacationService
{
    Task<bool> Insert(VacationAddDto model);
    Task<bool> InsertNextStatePlan(VacationInsertNextInstanceDto model);
    Task<GridData<VacationCartablGetDto>> BindCartable(BaseGrid grid);
    Task<GridData<VacationGetDto>> BindGrid(BaseGrid grid);
}