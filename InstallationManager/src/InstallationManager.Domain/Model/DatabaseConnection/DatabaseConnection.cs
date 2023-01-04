namespace InstallationManager.Domain.Model.DatabaseConnection
{
    public class DatabaseConnection
    {
        public string Name { get; set; }
        public DatabaseType DatabaseType { get; set; }
        public BaseDatabaseConnectionDetails ConnectionDetails { get; set; }
        public bool IsValid { get; set; }
    }
}
