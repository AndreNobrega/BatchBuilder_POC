using InstallationManager.Domain.Model.DatabaseConnection;
using System.Collections.Generic;

namespace InstallationManager.Domain.Validators
{
	public interface IDatabaseConnectionValidator
	{
		bool IsValid(DatabaseConnection databaseConnection);
		bool IsValid(List<DatabaseConnection> databaseConnections);
	}
}