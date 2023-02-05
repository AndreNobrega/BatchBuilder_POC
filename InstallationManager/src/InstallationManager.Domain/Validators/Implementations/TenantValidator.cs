using InstallationManager.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace InstallationManager.Domain.Validators.Implementations
{
	internal class TenantValidator : ITenantValidator
	{
		private readonly IDatabaseConnectionValidator _databaseConnectionConfigValidator;

		public TenantValidator(IDatabaseConnectionValidator databaseConnectionConfigValidator)
		{
			_databaseConnectionConfigValidator = databaseConnectionConfigValidator;
		}

		public bool IsValid(List<Tenant> tenants)
		{
			return 
				tenants.All(t => IsValid(t))
				&& TenantIdsAreUnique(tenants);
		}

		public bool IsValid(Tenant tenant)
		{
			return
				!string.IsNullOrWhiteSpace(tenant.Id)
				&& !string.IsNullOrWhiteSpace(tenant.Name)
				&& _databaseConnectionConfigValidator.IsValid(tenant.DatabaseConnection);
		}

		private static bool TenantIdsAreUnique(List<Tenant> tenants)
			=> tenants.Select(t => t.Id).Distinct().Count() == tenants.Count;
	}
}
