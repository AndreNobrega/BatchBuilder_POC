using Batches.Model.BatchRequest;

namespace Batches.Model.TaskHandlers
{
    public abstract class TaskHandlerBase
    {
        internal int TaskCount => 1 + (_nextHandler?.TaskCount ?? 0);
        protected readonly IBatchRequest _batchRequest;
        protected TaskHandlerBase? _nextHandler;

        protected TaskHandlerBase(IBatchRequest batchRequest)
        {
            _batchRequest = batchRequest;
        }

        internal TaskHandlerBase SetNext(TaskHandlerBase nextBatchHandler)
        {
            _nextHandler = nextBatchHandler;
            return _nextHandler;
        }

        internal abstract void Handle();
    }
}
