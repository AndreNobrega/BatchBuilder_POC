using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Application.Helpers
{
	public static class DirectoryHelper
	{
		/// <summary>
		/// Check if a user has access to specific path.
		/// 
		/// Based on a StackOverflow answer (https://stackoverflow.com/a/5394719/9066879)
		/// </summary>
		/// <param name="user"></param>
		/// <param name="path"></param>
		/// <returns>True if the user has access to the path, false otherwise.</returns>
		public static bool UserHasWriteAccessToPath(string user, string path)
		{
			DirectoryInfo di = new DirectoryInfo(path);
			DirectorySecurity acl = di.GetAccessControl(AccessControlSections.All);
			AuthorizationRuleCollection rules = acl.GetAccessRules(true, true, typeof(NTAccount));

			//Go through the rules returned from the DirectorySecurity
			foreach (AuthorizationRule rule in rules)
			{
				//If we find one that matches the identity we are looking for
				if (rule.IdentityReference.Value.Equals(user, StringComparison.CurrentCultureIgnoreCase))
				{
					var filesystemAccessRule = (FileSystemAccessRule)rule;

					//Cast to a FileSystemAccessRule to check for access rights
					if ((filesystemAccessRule.FileSystemRights & FileSystemRights.WriteData) > 0 && filesystemAccessRule.AccessControlType != AccessControlType.Deny)
					{
						Console.WriteLine(string.Format("{0} has write access to {1}", user, path));
					}
					else
					{
						Console.WriteLine(string.Format("{0} does not have write access to {1}", user, path));
					}

					return 
						(filesystemAccessRule.FileSystemRights & FileSystemRights.WriteData) > 0 
						&& filesystemAccessRule.AccessControlType != AccessControlType.Deny;
				}

				return false;
			}

			return false;
		}
	}
}
