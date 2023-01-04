namespace InstallationManager.Domain.DatabaseConnection
{
	public class OracleConnectionDetails : BaseDatabaseConnectionDetails
	{
		public bool UseTns { get; set; }
		public string DataSource { get; set; }
		public bool UseIntegratedSecurity { get; set; }
		public string Host { get; set; }
		public string Port { get; set; }
		public string ServiceName { get; set; }
		public Protocol Protocol { get; set; }
	}
}
