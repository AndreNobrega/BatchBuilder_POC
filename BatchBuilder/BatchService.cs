﻿using BatchBuilder.Model.Interfaces;

namespace Batches
{
    public class BatchService : IBatchService
    {
        private readonly BatchDirectorBase batchDirector;

        public BatchService(BatchDirectorBase batchDirector)
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
