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
					sb.Append($"User Id={connectionDetails.UserName};Password={(!censorPassword ? connectionDetails.Password : "* * *")};Integrated Security=no;");
			}
			else
			{
				sb.Append($"Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = {connectionDetails.Protocol})(HOST = {connectionDetails.Host})(PORT = {connectionDetails.Port}))(CONNECT_DATA = (SERVICE_NAME = {connectionDetails.ServiceName})));");
				sb.Append($"User Id = {connectionDetails.UserName}; Password = {(!censorPassword ? connectionDetails.Password : "* * *")};");
			}

			return sb.ToString();
		}

		internal static void GetDetailsFromConnectionString(this OracleConnectionDetails connectionDetails, string connectionString)
		{
			connectionDetails.UseTns = !connectionString.Contains($"Data Source = (DESCRIPTION = (ADDRESS =");
			connectionDetails.UseIntegratedSecurity = connectionString.Contains("Integrated Security=yes");

			//TODO: use regex to extract the other properties from the connection string

			connectionDetails.UserName = _userIdRegex.Match(connectionString).ToString();
			connectionDetails.Password = _passwordRegex.Match(connectionString).ToString();
			connectionDetails.Host = _hostRegex.Match(connectionString).ToString();
			connectionDetails.Port = _portRegex.Match(connectionString).ToString();
			connectionDetails.ServiceName = _serviceNameRegex.Match(connectionString).ToString();
		}

		private static string ExtractValueFromConnectionString(Regex regex, string connectionString)
		{
			throw new NotImplementedException();

			/*
			 * TODO
			 * clean up whitespaces
			 * remove parameter name and equals sign ("DESCRIPTION = ")
			 * extract value
			 */

			var parameter = regex.Match(connectionString).ToString();
			var parameterWithoutSpaces = _removeSpacesRegex.Match(parameter).ToString();

		}

		#region Regex
		[GeneratedRegex("(?<=(?i)User Id=).+?(?=\\;)", RegexOptions.None, "en-BE")]
		private static partial Regex UserIdRegex();
		private static readonly Regex _userIdRegex = UserIdRegex();

		[GeneratedRegex("(?<=(?i)Password=).+?(?=\\;)", RegexOptions.None, "en-BE")]
		private static partial Regex PasswordRegex();
		private static readonly Regex _passwordRegex = PasswordRegex();

		[GeneratedRegex("(?<=(?i)Host=).+?(?=\\))", RegexOptions.None, "en-BE")]
		private static partial Regex HostRegex();
		private static readonly Regex _hostRegex = HostRegex();

		[GeneratedRegex("(?<=(?i)Port=).+?(?=\\))", RegexOptions.None, "en-BE")]
		private static partial Regex PortRegex();
		private static readonly Regex _portRegex = PortRegex();

		[GeneratedRegex("(?<=(?i)SERVICE_NAME=).+?(?=\\))", RegexOptions.None, "en-BE")]
		private static partial Regex ServiceNameRegex();
		private static readonly Regex _serviceNameRegex = ServiceNameRegex();

		[GeneratedRegex("\\s*=\\s*", RegexOptions.None, "en-BE")]
		private static partial Regex RemoveSpacesRegex();
		private static readonly Regex _removeSpacesRegex = RemoveSpacesRegex();
		#endregion
	}
}
