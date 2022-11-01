using Notifications.Model.Interfaces;

namespace BatchBuilder.Model.Interfaces
{
    public abstract class BatchBase
    {
        protected readonly IBatchRequest _request;
        protected readonly TaskHandlerBase _initialTask;
        protected int TaskCount => _initialTask.TaskCount;

        internal BatchBase(IBatchRequest request, TaskHandlerBase initialTask)
        {
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _initialTask = initialTask ?? throw new ArgumentNullException(nameof(initialTask));
        }

        internal virtual bool Run()
        {
            try
            {
                _initialTask.Handle();
                return true;
            }
            catch (Exception)
            {
                // todo: log error
                return false;
            }
        }

        protected virtual void UpdateNotification(INotification notification)
        {
            throw new NotImplementedException();
        }
    }
}
