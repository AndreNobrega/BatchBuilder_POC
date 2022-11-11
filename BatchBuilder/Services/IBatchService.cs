using Shared.Model;

namespace Batches.Services
{
    public interface IBatchService
    {
        bool StartMaintenanceBatch();
        bool StartEmailBatch(Memo memo);
    }
}