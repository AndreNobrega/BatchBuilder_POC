using InstallationManager.Domain.Model;

namespace InstallationManager.Domain.Validators
{
	internal interface IInstallationValidator
	{
		bool IsValid(Installation installation);
	}
}