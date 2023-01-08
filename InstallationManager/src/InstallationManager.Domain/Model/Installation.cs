using System.Collections.Generic;

namespace InstallationManager.Domain.Model
{
    public class Installation
    {
        public IisConfiguration.IisConfiguration IisConfiguration { get; set; }
        public List<Tenant> Tenants { get; set; }
        public List<DatabaseConnection.DatabaseConnection> DatabaseConnections { get; set; }
    }
}
