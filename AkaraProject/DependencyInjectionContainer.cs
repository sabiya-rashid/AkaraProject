using Common.DTOs.Property;
using Common.DTOs.UserDto;
using Common.Validations;
using FluentValidation;
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
            services.AddTransient<IValidator<LoginDto>, LoginValidator>();
            services.AddTransient<IValidator<RegisterDto>, RegisterValidator>();
            services.AddTransient<IValidator<PropertyDto>, PropertyValidator>();
            return services;
        }
    }
}
