using System;
using UpdateService.Core.Entities;
using UpdateService.Core.Interfaces;

namespace UpdateService.Core.Services
{
	public class UpdateService : IUpdateService
	{
		private readonly IFileTransferService _fileTransferService;
		private readonly IManifestService _manifestService;

		public UpdateService(IFileTransferService fileTransferService, IManifestService manifestService)
		{
			_fileTransferService = fileTransferService;
			_manifestService = manifestService;
		}

		public bool IsUpdateAvailable(DeployEnvironment environment)
		{
			var globalManifest = _fileTransferService.GetGlobalVersionManifest();
			return _manifestService.IsUpdateAvailable(globalManifest);
		}

		public void DownloadUpdate(DeployEnvironment environment)
		{
			throw new NotImplementedException();
		}
	}
}
