using BatchBuilder.Model.Enums;

namespace Batches.Model.BatchRequest
{
    public interface IBatchRequest
    {
        public string BatchId { get; set; }
        public BatchType BatchType { get; set; }
    }
}
