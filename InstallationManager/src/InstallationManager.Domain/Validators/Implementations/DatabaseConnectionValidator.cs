using InstallationManager.Domain.Model.DatabaseConnection;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace InstallationManager.Domain.Validators.Implementations
{
	internal class DatabaseConnectionValidator : IDatabaseConnectionValidator
	{
		public bool IsValid(List<DatabaseConnection> databaseConnections)
		{
			return
				databaseConnections.All(IsValid)
				&& ConnectionNamesAreUnique(databaseConnections);
		}

		public bool IsValid(DatabaseConnection databaseConnection)
		{
			return
				!string.IsNullOrWhiteSpace(databaseConnection.Name)
				&& databaseConnection.ConnectionDetails != null
				&& ConnectionDetailsAreValid(databaseConnection.ConnectionDetails);
		}

		private static bool ConnectionNamesAreUnique(List<DatabaseConnection> connections)
			=> connections.Select(t => t.Name).Distinct().Count() == connections.Count;

		private static bool ConnectionDetailsAreValid(BaseDatabaseConnectionDetails databaseConnectionDetails)
		{
			try
			{
				using (DbConnection connection = GetDbConnection(databaseConnectionDetails))
				{
					connection.Open();
					connection.Close();
				}

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private static DbConnection GetDbConnection(BaseDatabaseConnectionDetails connectionDetails)
		{
			if (connectionDetails is SqlConnectionDetails)
				return new SqlConnection(connectionDetails.ConnectionString);

			else if (connectionDetails is OracleConnectionDetails)
				return new OracleConnection(connectionDetails.ConnectionString);

			else throw new NotImplementedException($"Database connection type {connectionDetails.GetType().Name} not implemented.");
		}
	}
}
