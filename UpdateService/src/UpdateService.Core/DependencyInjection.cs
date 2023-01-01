using Microsoft.Extensions.DependencyInjection;
using UpdateService.Core.Interfaces;
using UpdateService.Core.Services;

namespace UpdateService.Core
{
	public static class DependencyInjection
	{
		public static void AddCoreServices(this IServiceCollection services)
		{
			services.AddScoped<IConfigurationService, ConfigurationService>();
		}
	}
}
