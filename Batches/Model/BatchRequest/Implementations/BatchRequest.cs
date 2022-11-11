using BatchBuilder.Model.Enums;

namespace Batches.Model.BatchRequest.Implementations
{
    public class BatchRequest : IBatchRequest
    {
        public string? BatchId { get; set; }
        public BatchType BatchType { get; set; }
    }
}
