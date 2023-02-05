using InstallationManager.Domain.Model.DatabaseConnection;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace InstallationManager.Domain.Extensions
{
	internal static partial class OracleConnectionDetailsExtensions
	{
		internal static string GetConnectionString(this OracleConnectionDetails connectionDetails, bool censorPassword = false)
		{
			StringBuilder sb = new();

			if (connectionDetails.UseTns)
			{
				sb.Append($"Data Source={connectionDetails.DataSource};");

				if (connectionDetails.UseIntegratedSecurity)
					sb.Append("Integrated Security=yes;");

				else
					sb.Append($"User Id={connectionDetails.UserId};Password={(!censorPassword ? connectionDetails.Password : "* * *")};Integrated Security=no;");
			}
			else
			{
				sb.Append($"Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = {connectionDetails.Protocol})(HOST = {connectionDetails.Host})(PORT = {connectionDetails.Port}))(CONNECT_DATA = (SERVICE_NAME = {connectionDetails.ServiceName})));");
				sb.Append($"User Id = {connectionDetails.UserId}; Password = {(!censorPassword ? connectionDetails.Password : "* * *")};");
			}

			return sb.ToString();
		}

		internal static void GetDetailsFromConnectionString(this OracleConnectionDetails connectionDetails, string connectionString)
		{
			connectionDetails.UseTns = !connectionString.Contains($"Data Source = (DESCRIPTION = (ADDRESS =");
			connectionDetails.UseIntegratedSecurity = connectionString.Contains("Integrated Security=yes");

			connectionDetails.UserId = _userIdRegex.Match(connectionString).ToString() ?? _uidRegex.Match(connectionString).ToString();
			connectionDetails.Password = _passwordRegex.Match(connectionString).ToString() ?? _pwdRegex.Match(connectionString).ToString();
			connectionDetails.Host = _hostRegex.Match(connectionString).ToString();
			connectionDetails.Port = _portRegex.Match(connectionString).ToString();
			connectionDetails.ServiceName = _serviceNameRegex.Match(connectionString).ToString();
		}	

		#region Regex
		[GeneratedRegex("(?i)User Id\\s*=\\s*([^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex UserIdRegex();
		private static readonly Regex _userIdRegex = UserIdRegex();
		
		[GeneratedRegex("(?i)uid\\s*=\\s*([^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex UidRegex();
		private static readonly Regex _uidRegex = UserIdRegex();

		[GeneratedRegex("(?i)Password\\s*=\\s*([^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex PasswordRegex();
		private static readonly Regex _passwordRegex = PasswordRegex();
		
		[GeneratedRegex("(?i)pwd\\s*=\\s*([^;]*);", RegexOptions.None, "en-GB")]
		private static partial Regex PwdRegex();
		private static readonly Regex _pwdRegex = PasswordRegex();

		[GeneratedRegex("(?i)HOST\\s*=\\s*([^)]*)\\s*\\)", RegexOptions.None, "en-GB")]
		private static partial Regex HostRegex();
		private static readonly Regex _hostRegex = HostRegex();

		[GeneratedRegex("(?i)PORT\\s*=\\s*([^)]*)\\s*\\)", RegexOptions.None, "en-GB")]
		private static partial Regex PortRegex();
		private static readonly Regex _portRegex = PortRegex();

		[GeneratedRegex("(?i)SERVICE_NAME\\s*=\\s*([^)]*)\\s*\\)", RegexOptions.None, "en-GB")]
		private static partial Regex ServiceNameRegex();
		private static readonly Regex _serviceNameRegex = ServiceNameRegex();
		#endregion
	}
}
