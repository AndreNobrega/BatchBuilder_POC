using InstallationManager.Domain.Extensions;

namespace InstallationManager.Domain.Model.DatabaseConnection
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

		protected override string ComposeConnectionString(bool censorPassword = false)
		{
            return this.GetConnectionString(censorPassword);
		}

		protected override void DeconstructConnectionString(string connectionString)
		{
            this.GetDetailsFromConnectionString(connectionString);   
		}
	}
}