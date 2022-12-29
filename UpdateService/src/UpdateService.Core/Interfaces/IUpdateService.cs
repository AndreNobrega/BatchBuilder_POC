using UpdateService.Core.Entities;

namespace UpdateService.Core.Interfaces
{
	public interface IUpdateService
	{
		/// <summary>
		/// Checks whether or not a software update is available.
		/// </summary>
		/// <param name="environment">The deployment environment for which to check whether or not there is an environment.</param>
		/// <returns>True if an update is available, false otherwise.</returns>
		public bool IsUpdateAvailable(DeployEnvironment environment);
		
		/// <summary>
		/// Update a deployment environment, if an update is available.
		/// </summary>
		/// <param name="environment">The environment to update.</param>
		public void Update(DeployEnvironment environment);
	}
}
