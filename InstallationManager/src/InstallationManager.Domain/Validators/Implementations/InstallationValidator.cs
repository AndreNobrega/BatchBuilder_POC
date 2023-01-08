using InstallationManager.Domain.Model;
using System.Linq;

namespace InstallationManager.Domain.Validators.Implementations
{
    internal class InstallationValidator : IInstallationValidator
    {
        private readonly ITenantValidator _tenantValidator;
        private readonly IIisConfigurationValidator _iisConfigurationValidator;
        private readonly IDatabaseConnectionValidator _databaseConnectionValidator;

		public InstallationValidator(ITenantValidator tenantValidator, IIisConfigurationValidator iisConfigurationValidator, IDatabaseConnectionValidator databaseConnectionValidator)
		{
			_tenantValidator = tenantValidator;
			_iisConfigurationValidator = iisConfigurationValidator;
			_databaseConnectionValidator = databaseConnectionValidator;
		}

		public bool IsValid(Installation installation)
        {
            return
                _tenantValidator.IsValid(installation.Tenants)
                && _iisConfigurationValidator.IsValid(installation.IisConfiguration)
                && _databaseConnectionValidator.IsValid(installation.DatabaseConnections);
        }
    }
}
