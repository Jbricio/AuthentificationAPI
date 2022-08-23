using AuthentificationAPI.API;
using AuthentificationAPI.DTOS;
using AuthentificationAPI.Persistence;
using AuthentificationAPI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthentificationAPI.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddApiControllers()
                .AddServices()
                .AddMapper()
                .AddPersistence(configuration);
            return services;
        }
    }
}
