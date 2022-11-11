using Microsoft.Extensions.Configuration;

namespace Authentication
{
    public abstract class AuthenticationServiceBase
    {
        protected readonly IConfiguration _config;

        public AuthenticationServiceBase(IConfiguration configuration)
        {
            _config = configuration;
        }

        public abstract bool SignUp(string username, string password);
        public abstract bool LogIn(string username, string password);
        public abstract void LogOut(string username);
    }
}
