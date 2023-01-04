using Microsoft.Extensions.Configuration;

namespace Application.Common.Interfaces.Authentication
{
	public abstract class BaseAuthenticationService
	{
		protected readonly IConfiguration _config;

		public BaseAuthenticationService(IConfiguration configuration)
		{
			_config = configuration;
		}

		public abstract bool SignUp(string username, string password);
		public abstract bool LogIn(string username, string password);
		public abstract void LogOut(string username);
	}
}
