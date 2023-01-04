namespace Domain.DatabaseConnection
{
	internal class SqlConnectionDetails : BaseDatabaseConnectionDetails
	{
		public string Server { get; set; }
		public string Database { get; set; }
		public string Port { get; set; }
		public bool TrustedConnection { get; set; }
	}
}
