using System;
using System.Threading.Tasks;
using UpdateService.Core.Entities.VersionManifest;
using UpdateService.Core.Interfaces;

namespace UpdateService.Infrastructure.Services
{
	// TODO: implement SftpService

	public class SftpService : IFileTransferService
	{
		public Task<string> GetBinaries(Core.Entities.DeployEnvironment environment)
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
