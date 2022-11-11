using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;
using Notifications.Model.Interfaces;
using Notifications.Services;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteSomethingElseTaskHandler : TaskHandlerBase
    {
        public DeleteSomethingElseTaskHandler(IBatchRequest batchRequest, INotificationService notificationService, IProgressNotification? progressNotification)
            : base(batchRequest, notificationService, progressNotification)
        {
            TaskLogic = DeleteSomethingElse;
        }

        protected override string NotificationMessage => "Deleting something else...";

        private void DeleteSomethingElse()
        {
            Console.WriteLine("Pretend I'm deleting something else...");
        }
    }
}
