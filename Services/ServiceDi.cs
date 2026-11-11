using Microsoft.Extensions.DependencyInjection;
using Services.Repositories.Interface._IAuth;
using Services.Repositories.Interface._IAuth.IGarrison;
using Services.Repositories.Interface._IAuth.ILocation;
using Services.Repositories.Interface._IAuth.IPosition;
using Services.Repositories.Interface._IAuth.IRole;
using Services.Repositories.Interface._IAuth.ISSO;
using Services.Repositories.Interface._IDocument;
using Services.Repositories.Interface.IClinic;
using Services.Repositories.Interface.IDossier;
using Services.Repositories.Interface.IEmploye;
using Services.Repositories.Interface.IStart;
using Services.Repositories.Interface.ITraffic;
using Services.Repositories.Interface.IVacation;
using Services.Repositories.Interface.IWorkPlace;
using Services.Repositories.Service._Auth;
using Services.Repositories.Service._Auth.Garrison;
using Services.Repositories.Service._Auth.Location;
using Services.Repositories.Service._Auth.Position;
using Services.Repositories.Service._Auth.Role;
using Services.Repositories.Service._Auth.SSO;
using Services.Repositories.Service._Document;
using Services.Repositories.Service.Clinic;
using Services.Repositories.Service.Dossier;
using Services.Repositories.Service.Employe;
using Services.Repositories.Service.Start;
using Services.Repositories.Service.Traffic;
using Services.Repositories.Service.Vacation;
using Services.Repositories.Service.WorkPlace;

namespace Services;

public static class ServiceDi
{
    public static void DiService(this IServiceCollection services)
    {
        services.AddScoped<IDocumentService, DocumentService>();

        #region Auth
        services.AddScoped<ISsoService, SsoService>();
        services.AddScoped<IGarrisonService, GarrisonService>();
        services.AddScoped<ILocationService, LocationService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IPositionService, PositionService>();
        services.AddScoped<IFormService, FormService>();
        #endregion           

        #region Start
        services.AddScoped<IClearingService, ClearingService>();
        services.AddScoped<IClosedService, ClosedService>();
        services.AddScoped<IDossierListService, DossierListService>();
        services.AddScoped<IEducationLevelService, EducationLevelService>();
        services.AddScoped<IEscapeService, EscapeService>();
        services.AddScoped<ITrafficStatusService, TrafficStatusService>();
        services.AddScoped<IResidenceTypeService, ResidenceTypeService>();
        services.AddScoped<IVacationTypeService, VacationTypeService>();
        #endregion

        #region Emoloye
        services.AddScoped<IEmployeService, EmployeService>();
        services.AddScoped<IServiceLineTypeService, ServiceLineTypeService>();
        services.AddScoped<IEmployeComplementService, EmployeComplementService>();
        services.AddScoped<IEmployeMembershipType, EmployeMembershipType>();
        services.AddScoped<IHealthStatusTypeService, HealthStatusTypeService>();
        services.AddScoped<IServiceStatusService, ServiceStatusService>();
        services.AddScoped<IServiceStatusTypeService, ServiceStatusTypeService>();
        services.AddScoped<IDegreeTypeService, DegreeTypeService>();
        #endregion

        #region Dossier
        services.AddScoped<IDossierService, DossierService>();
        #endregion

        #region Clinic
        services.AddScoped<IClinicService, ClinicService>();
        #endregion

        #region Vacation
        services.AddScoped<IVacationService, VacationService>();
        #endregion

        #region Traffic
        services.AddScoped<ITrafficService, TrafficService>();
        #endregion

        #region WorkPlace
        services.AddScoped<IWorkPlaceService, WorkPlaceService>();
        #endregion
    }
}