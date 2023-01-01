using UpdateService.Core.Entities.VersionManifest;

namespace UpdateService.Core.Interfaces
{
    public interface IManifestService
	{
		public LocalVersionManifest GetLocalVersionManifest();

		/// <summary>
		/// Check the global version manifest to see if an update is available.
		/// </summary>
		/// <param name="globalManifest">The global manifest to read out.</param>
		/// <returns>True if an update is available, false otherwise.</returns>
		public bool IsUpdateAvailable(GlobalVersionManifest globalManifest);
	}
}
