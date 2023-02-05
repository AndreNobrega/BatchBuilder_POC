using InstallationManager.Domain.Model;
using System.Collections.Generic;

namespace InstallationManager.Domain.Validators
{
	internal interface ITenantValidator
	{
		bool IsValid(List<Tenant> tenants);
	}
}