using InstallationManager.Domain.Extensions;

namespace InstallationManager.Domain.Model.DatabaseConnection
{
	public class SqlConnectionDetails : BaseDatabaseConnectionDetails
    {
        public string Server { get; set; }
        public string Database { get; set; }
		public int? Port { get; set; }
        public bool TrustedConnection { get; set; }

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
