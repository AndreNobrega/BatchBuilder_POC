using BatchBuilder.Model.Interfaces;

namespace Batches
{
    public abstract class BatchDirectorBase
    {
        internal abstract BatchBase BuildBatch(IBatchRequest request);
    }
}