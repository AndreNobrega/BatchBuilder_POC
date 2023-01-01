using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UpdateService.Core.Interfaces;

namespace UpdateService.Worker
{
	public class Worker : BackgroundService
	{
		private readonly ILogger<Worker> _logger;
		private readonly IUpdateService _updateService;
		private readonly IConfigurationService _configurationService;

		private readonly int delayInMilliseconds = 60 * 1000;

		public Worker(ILogger<Worker> logger, IUpdateService updateService, IConfigurationService configurationService)
		{
			_logger = logger;
			_updateService = updateService;
			_configurationService = configurationService;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

				CheckForUpdates();

				await Task.Delay(delayInMilliseconds, stoppingToken);
			}
		}

		public bool CheckForUpdates()
		{
			var environmentsToCheck = _configurationService.GetTenants().Select(t => t.Environment).Distinct();
			List<bool> updatesAvailable = new List<bool>();

			foreach (var environment in environmentsToCheck)
			{
				var isUpdateAvailable = _updateService.IsUpdateAvailable(environment);
				updatesAvailable.Add(isUpdateAvailable);
			}

			return updatesAvailable.Any(b => b == true);
		}
	}
}
