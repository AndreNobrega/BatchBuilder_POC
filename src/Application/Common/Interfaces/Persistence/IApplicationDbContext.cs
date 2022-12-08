using System.Data.Entity;

namespace Application.Common.Interfaces.Persistence
{
	public interface IApplicationDbContext
	{
		DbSet<Domain.Entities.Memo> Memos { get; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
