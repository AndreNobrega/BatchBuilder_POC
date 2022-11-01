using Batches.Model.Batches;
using Batches.Model.BatchRequest;

namespace Batches.Services
{
    public abstract class BatchBuilderDirectorBase
    {
        internal abstract BatchBase BuildBatch(IBatchRequest request);
    }
}