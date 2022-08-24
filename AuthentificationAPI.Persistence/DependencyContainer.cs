using AuthentificationAPI.Contracts;
using AuthentificationAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthentificationAPI.Persistence
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SQLServer"),
                    x => x.MigrationsAssembly(typeof(RepositoryContext).Assembly.GetName().Name));                
            });
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
