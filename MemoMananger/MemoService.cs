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
            _batchService.StartMaintenanceBatch();
        }
    }
}
