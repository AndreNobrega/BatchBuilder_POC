using InstallationManager.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace InstallationManager.Application
{
	public static class DependencyInjection
	{
		public static void AddApplicationServices(this IServiceCollection services)
		{
			services.AddDomainServices();
		}
	}
}
