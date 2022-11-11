using Shared.Model;

namespace Repositories.Memos
{
    public interface IMemoRepository
    {
        /// <summary>
        /// Add a memo to the database.
        /// </summary>
        /// <param name="memo"></param>
        /// <returns>The memo's ID.</returns>
        int AddMemo(Memo memo);

        /// <summary>
        /// Deletes a memo from the database.
        /// </summary>
        /// <param name="id">The memo's ID.</param>
        void DeleteMemo(int id);

        /// <summary>
        /// Gets a memo from the database.
        /// </summary>
        /// <param name="id">The memo's ID.</param>
        /// <returns>A memo, if the ID exists.</returns>
        Memo GetMemo(int id);

        /// <summary>
        /// Updates a memo in the database.
        /// </summary>
        /// <param name="memo"></param>
        void UpdateMemo(Memo memo);
    }
}