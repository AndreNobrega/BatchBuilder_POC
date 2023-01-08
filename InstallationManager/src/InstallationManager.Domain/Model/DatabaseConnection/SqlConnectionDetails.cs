using System.Text;

namespace InstallationManager.Domain.Model.DatabaseConnection
{
    internal class SqlConnectionDetails : BaseDatabaseConnectionDetails
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Port { get; set; }
        public bool TrustedConnection { get; set; }

		protected override string ComposeConnectionString(bool censorPassword = false)
		{
            StringBuilder sb = new();

			sb.Append($"Server={Server}");
			if (Port != null) sb.Append($",{Port}");
			sb.Append($"Database={Database};");


			if (TrustedConnection)
                sb.Append("Trusted_Connection=True;");                
            else
                sb.Append($"User Id={UserName};Password={(!censorPassword ? Password : "* * *")}");
            
            return sb.ToString();
		}

		protected override void DeconstructConnectionString(string connectionString)
		{
			// TODO: implement DeconstructConnectionString() method for SQL
			throw new System.NotImplementedException();
		}
	}
}
