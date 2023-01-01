using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
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
			throw new NotImplementedException();
		}

		public List<Tenant> GetTenants()
		{
			throw new NotImplementedException();
		}
	}
}
