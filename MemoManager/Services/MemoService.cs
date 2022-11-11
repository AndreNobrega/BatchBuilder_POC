using Batches.Services;

namespace MemoManager.Services
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
