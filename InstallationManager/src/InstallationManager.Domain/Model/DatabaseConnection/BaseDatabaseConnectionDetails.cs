namespace InstallationManager.Domain.Model.DatabaseConnection
{
    public abstract class BaseDatabaseConnectionDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
