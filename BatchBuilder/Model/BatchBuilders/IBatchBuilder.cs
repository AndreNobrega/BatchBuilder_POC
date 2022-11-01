using Batches.Model.Batches;
using Batches.Model.BatchRequest;

namespace Batches.Model.BatchBuilders
{
    internal interface IBatchBuilder
    {
        public BatchBase BuildBatch(IBatchRequest request);
    }
}