using BatchBuilder.Model.Enums;

namespace BatchBuilder.Model.Interfaces
{
    public interface IBatchRequest
    {
        public string BatchId { get; set; }
        public BatchType BatchType { get; set; }
    }
}
