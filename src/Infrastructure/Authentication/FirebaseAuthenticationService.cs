using Application.Common.Interfaces.Authentication;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Authentication
{
	internal class FirebaseAuthenticationService : BaseAuthenticationService
	{
		public FirebaseAuthenticationService(IConfiguration configuration) : base(configuration)
		{
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
