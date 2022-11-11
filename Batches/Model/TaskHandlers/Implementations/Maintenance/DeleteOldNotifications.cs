using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;
using Notifications.Model.Interfaces;
using Notifications.Services;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldNotificationsTaskHandler : TaskHandlerBase
    {
        public DeleteOldNotificationsTaskHandler(IBatchRequest batchRequest, INotificationService notificationService, IProgressNotification? progressNotification)
            : base(batchRequest, notificationService, progressNotification)
        {
            TaskLogic = DeleteOldNotifications;
        }

        protected override string NotificationMessage => "Deleting old notifications...";

        private void DeleteOldNotifications()
        {
            Console.WriteLine("Pretend I'm deleting old notifications...");
        }
    }
}
