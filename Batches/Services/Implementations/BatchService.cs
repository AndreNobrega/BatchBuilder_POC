using Batches.Model.BatchRequest.Implementations;
using Shared.Model;

namespace Batches.Services.Implementations
{
    public class BatchService : IBatchService
    {
        private readonly BatchBuilderDirectorBase batchDirector;

        public BatchService(BatchBuilderDirectorBase batchDirector)
        {
            this.batchDirector = batchDirector;
        }

        public bool StartEmailBatch(Memo memo)
        {
            // todo: implement email batch logic
            throw new NotImplementedException();
        }

        public bool StartMaintenanceBatch()
        {
            var request = new BatchRequest()
            {
                BatchType = BatchBuilder.Model.Enums.BatchType.Maintenance
            };

            var batch = batchDirector.BuildBatch(request);
            return batch.Run();
        }
    }
}
