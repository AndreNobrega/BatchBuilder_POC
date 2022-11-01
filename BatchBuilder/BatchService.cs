using BatchBuilder.Model.Interfaces;

namespace Batches
{
    public class BatchService : IBatchService
    {
        private readonly BatchBuilderDirectorBase batchDirector;

        public BatchService(BatchBuilderDirectorBase batchDirector)
        {
            this.batchDirector = batchDirector;
        }

        public bool StartBatch(IBatchRequest request)
        {
            var batch = batchDirector.BuildBatch(request);
            return batch.Run();
        }
    }
}
