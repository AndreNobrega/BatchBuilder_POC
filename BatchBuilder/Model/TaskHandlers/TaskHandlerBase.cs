using Batches.Model.BatchRequest;
using Notifications.Model.Interfaces;
using Notifications.Services;

namespace Batches.Model.TaskHandlers
{
    public abstract class TaskHandlerBase
    {
        protected readonly INotificationService notificationService;
        protected readonly IBatchRequest batchRequest;
        protected readonly IProgressNotification? progressNotification;
        protected TaskHandlerBase? _nextHandler;
        protected delegate void TaskLogicDelegate();
        protected TaskLogicDelegate? TaskLogic;
        public delegate void Del(string message);
        internal int TaskCount => 1 + (_nextHandler?.TaskCount ?? 0);

        //protected abstract string NotificationMessage { get; set; }
        protected abstract string NotificationMessage { get; }


        protected TaskHandlerBase(INotificationService notificationService, IBatchRequest batchRequest, IProgressNotification? progressNotification)
        {
            this.notificationService = notificationService;
            this.batchRequest = batchRequest;
            this.progressNotification = progressNotification;
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
        public virtual void Handle()
        {
            if (TaskLogic is null)
                throw new ArgumentNullException("Task logic has not been set.");

            UpdateNotification();

            TaskLogic();

            _nextHandler?.Handle();
        }

        protected virtual void UpdateNotification()
        {
            if (progressNotification != null)
            {
                progressNotification.Message = NotificationMessage;
                notificationService.UpdateNotification(progressNotification);
            }
        }
    }
}
