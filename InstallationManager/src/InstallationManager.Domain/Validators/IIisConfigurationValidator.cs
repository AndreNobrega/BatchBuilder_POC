using InstallationManager.Domain.Model.IisConfiguration;

namespace InstallationManager.Domain.Validators
{
	internal interface IIisConfigurationValidator
	{
		bool IsValid(IisConfiguration iisConfiguration);
	}
}