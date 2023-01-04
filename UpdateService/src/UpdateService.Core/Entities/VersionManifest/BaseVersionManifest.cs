namespace UpdateService.Core.Entities.VersionManifest
{
	public abstract class BaseVersionManifest
	{
		public string Version { get; set; }
		public DeployEnvironment Environment { get; set; }
	}
}
