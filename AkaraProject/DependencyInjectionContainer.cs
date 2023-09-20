using Services.IServices;
using Services.Service;

namespace AkaraProject
{
    public static class DependencyInjectionContainer
    {
public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IPropertyService, PropertyService>();
            services.AddHttpContextAccessor();
            return services;
        }
    }
}
