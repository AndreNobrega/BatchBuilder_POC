using Domain.Entities;

namespace Application.Common.Interfaces.Batches
{
    public interface IBatchService
    {
        bool StartMaintenanceBatch();
        bool StartEmailBatch(Memo memo);
    }
}
