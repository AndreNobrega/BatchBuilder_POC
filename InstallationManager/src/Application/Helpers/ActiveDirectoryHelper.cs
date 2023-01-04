using System;
using System.DirectoryServices.AccountManagement;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Application.Helpers
{
	public static class ActiveDirectoryHelper
	{
		public static bool ADUserExists(string user)
		{
			throw new NotImplementedException();

			//using (var context = new PrinciPalContext())
			//{
			//	UserPrincipal principal = new UserPrincipal(context);
			//}
		}

		public static bool ADGroupExists(string group)
		{
			throw new NotImplementedException();
		}
	}
}
