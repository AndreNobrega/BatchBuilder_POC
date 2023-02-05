using InstallationManager.Domain.Model.DatabaseConnection;
using System.Text;
using System.Text.RegularExpressions;

namespace InstallationManager.Domain.Extensions
{
	internal static partial class SqlConnectionDetailsExtensions
	{
		private static readonly int _defaultPort = 1433;

		internal static string GetConnectionString(this SqlConnectionDetails connectionDetails, bool censorPassword = false)
		{
			StringBuilder sb = new();

			sb.Append($"Server={connectionDetails.Server}");
			if (connectionDetails.Port != null && connectionDetails.Port != _defaultPort) sb.Append($",{connectionDetails.Port}");
			sb.Append($"Database={connectionDetails.Database};");


			if (connectionDetails.TrustedConnection)
				sb.Append("Trusted_Connection=True;");
			else
				sb.Append($"User Id={connectionDetails.UserId};Password={(!censorPassword ? connectionDetails.Password : "* * *")}");

			return sb.ToString();
		}

		internal static void GetDetailsFromConnectionString(this SqlConnectionDetails connectionDetails, string connectionString)
		{
			connectionDetails.Server = _serverRegex.Match(connectionString).Value;
			connectionDetails.Port = _portRegex.IsMatch(connectionString)
				? int.Parse(_portRegex.Match(connectionString).Value)
				: null;

			connectionDetails.UserId = _userIdRegex.Match(connectionString).Value;
			connectionDetails.Password = _passwordRegex.Match(connectionString).Value;
			connectionDetails.Database = _databaseRegex.Match(connectionString).Value;
			connectionDetails.TrustedConnection = _trustedConnectionRegex.IsMatch(connectionString)
				? bool.Parse(_trustedConnectionRegex.Match(connectionString).Value)
				: false;
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
