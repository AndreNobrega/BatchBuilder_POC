using System.Collections.Generic;

namespace UpdateService.Core.Entities.Settings
{
    public class Tenant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DeployEnvironment Environment { get; set; }
    }

    public class Tenants
    {
        public List<Tenant> TenantSettings { get; set; }
    }
}
