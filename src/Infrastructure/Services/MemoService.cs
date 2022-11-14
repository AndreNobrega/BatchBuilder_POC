using Application.Common.Interfaces.Batches;

namespace Infrastructure.Services
{
    internal class MemoService
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
