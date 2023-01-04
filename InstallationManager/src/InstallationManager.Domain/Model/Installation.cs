using System.Collections.Generic;

namespace InstallationManager.Domain.Model
{
    public class Installation
    {
        public IisConfiguration.IisConfiguration IisConfiguration { get; set; }
        public List<Tenant> Tenants { get; set; }
        public bool IsValid { get; set; }

        // TODO: maybe this sort of logic shouldn't be in the model
        //private bool TenantIdsAreUnique() 
        //	=> Tenants.Select(t => t.Id).Distinct().Count() == Tenants.Count();
    }
}
