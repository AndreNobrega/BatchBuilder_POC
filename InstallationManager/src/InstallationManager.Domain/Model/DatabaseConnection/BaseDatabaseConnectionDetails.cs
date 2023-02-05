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
                return GetConnectionStringFromParams();
            }
            set
            {
                GetParamsFromConnectionString();
            }
        }
        
        public string CensoredConnectionString { 
            get
            {
                return GetConnectionStringFromParams(true);
            } 
        }

        public abstract string GetConnectionStringFromParams(bool censorPassword = false);
        public abstract void GetParamsFromConnectionString();
    }
}
