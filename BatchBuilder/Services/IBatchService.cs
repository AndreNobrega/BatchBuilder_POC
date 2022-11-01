using Batches.Model.BatchRequest;

namespace Batches.Services
{
    public interface IBatchService
    {
        bool StartBatch(IBatchRequest request);
    }
}