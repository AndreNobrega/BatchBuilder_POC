using BatchBuilder.Model.Interfaces;

namespace Batches
{
    public abstract class BatchBuilderDirectorBase
    {
        internal abstract BatchBase BuildBatch(IBatchRequest request);
    }
}