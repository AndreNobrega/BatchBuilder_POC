namespace InstallationManager.Domain.Model.DatabaseConnection
{
    public abstract class BaseDatabaseConnectionDetails
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConnectionString
        {
            get
            {
                return ComposeConnectionString();
            }
            set
            {
                DeconstructConnectionString(value);
            }
        }
        
        public string CensoredConnectionString { 
            get
            {
                return ComposeConnectionString(true);
            } 
        }

        protected abstract string ComposeConnectionString(bool censorPassword = false);
        protected abstract void DeconstructConnectionString(string connectionString);
    }
}
