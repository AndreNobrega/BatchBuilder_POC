using System.DirectoryServices.AccountManagement;

namespace InstallationManager.Helpers
{
	public static class ActiveDirectoryHelper
	{
		/// <summary>
		/// Checks if a user exists in the Active Directory.
		/// </summary>
		/// <param name="userName"></param>
		/// <returns>True if the user exists, false otherwise.</returns>
		public static bool ADUserExists(string userName)
		{
			// Disable warning: method only works on Windows
#pragma warning disable CA1416 // Validate platform compatibility
			using var context = new PrincipalContext(ContextType.Domain);
			var adUser = UserPrincipal.FindByIdentity(context, userName);

			return adUser != null;
#pragma warning restore CA1416 // Validate platform compatibility
		}

		/// <summary>
		/// Checks if a group exists in the Active Directory.
		/// </summary>
		/// <param name="groupName"></param>
		/// <returns>True if the group exists, false otherwise.</returns>
		public static bool ADGroupExists(string groupName)
		{
			// Disable warning: method only works on Windows
#pragma warning disable CA1416 // Validate platform compatibility
			using var context = new PrincipalContext(ContextType.Domain);
			var adGroup = GroupPrincipal.FindByIdentity(context, groupName);

			return adGroup != null;
#pragma warning restore CA1416 // Validate platform compatibility
		}
	}
}
