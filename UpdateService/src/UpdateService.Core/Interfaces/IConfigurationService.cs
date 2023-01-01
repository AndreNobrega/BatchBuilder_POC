using System.Collections.Generic;
using UpdateService.Core.Entities.Settings;

namespace UpdateService.Core.Interfaces
{
    public interface IConfigurationService
	{
		public List<Tenant> GetTenants();
	}
}
