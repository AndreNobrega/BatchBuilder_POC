using Batches.Model.BatchRequest;
using Batches.Model.BatchRequest.Implementations;
using Batches.Services;

namespace MemoMananger
{
    public class MemoService : IMemoService
    {
        private readonly IBatchService _batchService;

        public MemoService(IBatchService batchService)
        {
            _batchService = batchService;
        }

        public void TestBatch()
        {
            var testBatch = new BatchRequest() { BatchType = BatchBuilder.Model.Enums.BatchType.Maintenance };
            _batchService.StartBatch(testBatch);
        }
    }
}
