namespace Domain
{
	public class Tenant
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public DatabaseConnection.DatabaseConnection DatabaseConnection { get; set; }
	}
}
