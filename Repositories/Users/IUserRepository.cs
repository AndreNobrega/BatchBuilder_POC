using Shared.Model;

namespace Repositories.Users
{
    internal interface IUserRepository
    {
        /// <summary>
        /// Adds a user to the database.
        /// </summary>
        /// <param name="user">The user to add.</param>
        /// <returns>The user's ID.</returns>
        int AddUser(User user);

        /// <summary>
        /// Delete a user from the database.
        /// </summary>
        /// <param name="id">The user's ID.</param>
        void DeleteUser(int id);

        /// <summary>
        /// Get a user from the database.
        /// </summary>
        /// <param name="id">The user's ID.</param>
        /// <returns>A user, if the ID exists.</returns>
        User GetUser(int id);

        /// <summary>
        /// Update a user in the database.
        /// </summary>
        /// <param name="user">The user to update.</param>
        void UpdateUser(User user);
    }
}
