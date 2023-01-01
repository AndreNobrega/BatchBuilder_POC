using Microsoft.Extensions.DependencyInjection;
using UpdateService.Core.Interfaces;
using UpdateService.Infrastructure.Services;

namespace UpdateService.Infrastructure
{
	public static class DependencyInjection
	{
		public static void AddInfrastructureServices(this IServiceCollection services)
		{
			services.AddScoped<IFileTransferService, LocalFileService>();
		}
	}
}
