using System;
using System.Threading.Tasks;
using UpdateService.Core.Entities;
using UpdateService.Core.Entities.VersionManifest;
using UpdateService.Core.Interfaces;

namespace UpdateService.Infrastructure.Services
{
	public class LocalFileService : IFileTransferService
	{
		public Task<string> GetBinaries(DeployEnvironment environment)
		{
			throw new NotImplementedException();
		}

		public GlobalVersionManifest GetGlobalVersionManifest()
		{
			throw new NotImplementedException();
		}

		public void UploadLocalVersionManifest(LocalVersionManifest manifest)
		{
			throw new NotImplementedException();
		}
	}
}
