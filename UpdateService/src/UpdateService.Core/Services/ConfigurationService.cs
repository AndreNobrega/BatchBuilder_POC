using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using UpdateService.Core.Entities.Settings;
using UpdateService.Core.Interfaces;

namespace UpdateService.Core.Services
{
	public class ConfigurationService : IConfigurationService
	{
		private readonly IConfiguration _configuration;

		public ConfigurationService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public FileTransferSettings GetFileTransferSettings()
		{
			return _configuration.Get<FileTransferSettings>();
		}

		public List<Tenant> GetTenants()
		{
			return _configuration.Get<Tenants>()?.TenantSettings ?? new List<Tenant>();
		}
	}
}
