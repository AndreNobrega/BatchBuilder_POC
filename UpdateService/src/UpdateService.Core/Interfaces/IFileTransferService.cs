using System.Threading.Tasks;
using UpdateService.Core.Entities;
using UpdateService.Core.Entities.VersionManifest;

namespace UpdateService.Core.Interfaces
{
    public interface IFileTransferService
	{
		/// <summary>
		/// Retrieve the global version manifest from the remote server.
		/// </summary>
		/// <returns>The global version manifest.</returns>
		public GlobalVersionManifest GetGlobalVersionManifest();

		/// <summary>
		/// Upload this customer's local version manifest to the remote server.
		/// </summary>
		/// <param name="manifest">The local version manifest to upload.</param>
		public void UploadLocalVersionManifest(LocalVersionManifest manifest);

		/// <summary>
		/// Get the most recent program binaries from the remote server, for the given environment.
		/// </summary>
		/// <param name="environment">The environment for which the binaries should be downloaded.</param>
		/// <returns>The local path of the binaries.</returns>
		public Task<string> GetBinaries(DeployEnvironment environment);
	}
}
