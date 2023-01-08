using InstallationManager.Domain.Validators;
using InstallationManager.Domain.Validators.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace InstallationManager.Domain
{
	public static class DependencyInjection
	{
		public static void AddDomainServices(this IServiceCollection services)
		{
			services.AddScoped<IInstallationValidator , InstallationValidator>();
			services.AddScoped<ITenantValidator , TenantValidator>();
			services.AddScoped<IIisConfigurationValidator, IisConfigurationValidator>();
			services.AddScoped<IDatabaseConnectionValidator, DatabaseConnectionValidator>();
		}
	}
}
