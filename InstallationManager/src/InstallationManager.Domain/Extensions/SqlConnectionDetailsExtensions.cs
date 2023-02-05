using InstallationManager.Domain.Model.DatabaseConnection;
using System.Text;
using System.Text.RegularExpressions;

namespace InstallationManager.Domain.Extensions
{
	internal static partial class SqlConnectionDetailsExtensions
	{
		private static readonly int _defaultPort = 1433;

		internal static string GetConnectionStringFromParams(this SqlConnectionDetails connectionDetails, bool censorPassword = false)
		{
			StringBuilder sb = new();

			sb.Append($"Server={connectionDetails.Server};");
			if (connectionDetails.Port != null && connectionDetails.Port != _defaultPort) sb.Append($",{connectionDetails.Port}");
			sb.Append($"Database={connectionDetails.Database};");


			if (connectionDetails.TrustedConnection)
				sb.Append("Trusted_Connection=True;");
			else
				sb.Append($"User Id={connectionDetails.UserId};Password={(!censorPassword ? connectionDetails.Password : "* * *")}");

			return sb.ToString();
		}

		internal static void GetParamsFromConnectionString(this SqlConnectionDetails connectionDetails)
		{
			connectionDetails.Server = _serverRegex.Match(connectionDetails.ConnectionString).Value;
			connectionDetails.Port = _portRegex.IsMatch(connectionDetails.ConnectionString)
				? int.Parse(_portRegex.Match(connectionDetails.ConnectionString).Value)
				: null;

			connectionDetails.UserId = _userIdRegex.Match(connectionDetails.ConnectionString).Value;
			connectionDetails.Password = _passwordRegex.Match(connectionDetails.ConnectionString).Value;
			connectionDetails.Database = _databaseRegex.Match(connectionDetails.ConnectionString).Value;
			connectionDetails.TrustedConnection = _trustedConnectionRegex.IsMatch(connectionDetails.ConnectionString)
				&& bool.Parse(_trustedConnectionRegex.Match(connectionDetails.ConnectionString).Value);
		}

		#region Regex
		[GeneratedRegex("(?i)server\\s*=\\s*([^;,]*)[;,]", RegexOptions.None, "en-GB")]
		private static partial Regex ServerRegex();
		private static readonly Regex _serverRegex = ServerRegex();

		[GeneratedRegex("(?i)server\\s*=\\s*[^,]*,(\\d[^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex PortRegex();
		private static readonly Regex _portRegex = PortRegex();

		[GeneratedRegex("(?i)database\\s*=\\s*([^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex DatabaseRegex();
		private static readonly Regex _databaseRegex = DatabaseRegex();

		[GeneratedRegex("(?i)User Id\\s*=\\s*([^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex UserIdRegex();
		private static readonly Regex _userIdRegex = UserIdRegex();

		[GeneratedRegex("(?i)Password\\s*=\\s*([^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex PasswordRegex();
		private static readonly Regex _passwordRegex = PasswordRegex();

		[GeneratedRegex("(?i)Trusted_Connection\\s*=\\s*([(?i)true|(?i)false][^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex TrustedConnectionRegex();
		private static readonly Regex _trustedConnectionRegex = TrustedConnectionRegex();
		#endregion
	}
}
