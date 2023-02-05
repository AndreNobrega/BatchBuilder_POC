using InstallationManager.Domain.Extensions;

namespace InstallationManager.Domain.Model.DatabaseConnection
{
	public class SqlConnectionDetails : BaseDatabaseConnectionDetails
    {
        public string Server { get; set; }
        public string Database { get; set; }
		public int? Port { get; set; }
        public bool TrustedConnection { get; set; }

		public override string GetConnectionStringFromParams(bool censorPassword = false)
		{
			return SqlConnectionDetailsExtensions.GetConnectionStringFromParams(this, censorPassword);
		}

		public override void GetParamsFromConnectionString()
		{
			SqlConnectionDetailsExtensions.GetParamsFromConnectionString(this);
		}
	}
}
