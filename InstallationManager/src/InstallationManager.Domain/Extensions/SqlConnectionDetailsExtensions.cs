using InstallationManager.Domain.Model.DatabaseConnection;
using System;
using System.Text;

namespace InstallationManager.Domain.Extensions
{
	internal static class SqlConnectionDetailsExtensions
	{
		internal static string GetConnectionString(this SqlConnectionDetails connectionDetails, bool censorPassword = false)
		{
			StringBuilder sb = new();

			sb.Append($"Server={connectionDetails.Server}");
			if (connectionDetails.Port != null) sb.Append($",{connectionDetails.Port}");
			sb.Append($"Database={connectionDetails.Database};");


			if (connectionDetails.TrustedConnection)
				sb.Append("Trusted_Connection=True;");
			else
				sb.Append($"User Id={connectionDetails.UserName};Password={(!censorPassword ? connectionDetails.Password : "* * *")}");

			return sb.ToString();
		}

		internal static void GetDetailsFromConnectionString(this SqlConnectionDetails connectionDetails, string connectionString)
		{
			// todo: get SqlConnectionDetails values from connectionString

			throw new NotImplementedException();
		}
	}
}
