using CVHack.DAL;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CVHack.BLL;

public static class DependencyInjection
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccess(configuration);

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        
        services.AddScoped<IAuthService, AuthService>();

        services.AddScoped<IProfileService, ProfileService>();
        services.AddScoped<IExperienceService, ExperienceService>();
        services.AddScoped<IEducationService, EducationService>();
        services.AddScoped<ICertificationService, CertificationService>();

        services.AddScoped<IApplicationManager, ApplicationManager>();
        services.AddScoped<ISupportTicketManager, SupportTicketManager>();

        return services;
    }
}
