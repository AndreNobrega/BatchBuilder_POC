using Batches.Model.BatchRequest;

namespace Batches.Model.TaskHandlers
{
    public abstract class TaskHandlerBase
    {
        internal int TaskCount => 1 + (_nextHandler?.TaskCount ?? 0);
        protected readonly IBatchRequest _batchRequest;
        protected TaskHandlerBase? _nextHandler;

        protected delegate void TaskLogicDelegate();
        protected TaskLogicDelegate? TaskLogic;
        public delegate void Del(string message);

        protected TaskHandlerBase(IBatchRequest batchRequest)
        {
            _batchRequest = batchRequest;
        }

        internal TaskHandlerBase SetNext(TaskHandlerBase nextBatchHandler)
        {
            _nextHandler = nextBatchHandler;
            return _nextHandler;
        }

        /*
         * TODO
         * - Add error handling
         * - Add notification update behaviour
         */
        //internal abstract void Handle();

        public virtual void Handle()
        {
            if (TaskLogic is null)
                throw new ArgumentNullException("Task logic has not been set.");

            TaskLogic();

            _nextHandler?.Handle();
        }
    }
}
