using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace AuthentificationAPI.API
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddApiControllers(this IServiceCollection services)
		{
			/*services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "DesarrollosAPI", Version = "v1" });
			});*/			
			services.AddControllers();
			return services;
		}
	}
}
