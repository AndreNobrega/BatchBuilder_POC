using Microsoft.Extensions.Configuration;

namespace Authentication.Implementations
{
    public class FirebaseAuthenticationService : AuthenticationServiceBase
    {
        private readonly string _authEndpoint;

        public FirebaseAuthenticationService(IConfiguration configuration) : base(configuration)
        {
            _authEndpoint = _config["FirebaseSettings:AuthEndPoint"];
        }

        public override bool LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public override void LogOut(string username)
        {
            throw new NotImplementedException();
        }

        public override bool SignUp(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}