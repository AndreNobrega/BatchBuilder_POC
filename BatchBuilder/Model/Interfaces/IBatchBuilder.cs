using BatchBuilder.Model.Interfaces;

namespace Batches.Model.Interfaces
{
    internal interface IBatchBuilder
    {
        public BatchBase BuildBatch(IBatchRequest request);
    }
}