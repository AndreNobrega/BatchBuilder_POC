namespace UpdateService.Core.Entities
{
	public class Tenant
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public DeployEnvironment Environment { get; set; }
	}
}
