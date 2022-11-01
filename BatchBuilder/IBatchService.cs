using BatchBuilder.Model.Interfaces;

namespace Batches
{
    public interface IBatchService
    {
        bool StartBatch(IBatchRequest request);
    }
}