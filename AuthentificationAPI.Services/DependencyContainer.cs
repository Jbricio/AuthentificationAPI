using Microsoft.Extensions.DependencyInjection;

namespace AuthentificationAPI.Services
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
