using Services.IServices;
using Services.Service;

namespace AkaraProject
{
    public static class DependencyInjectionContainer
    {
public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPropertyService, PropertyService>();
            return services;
        }
    }
}
