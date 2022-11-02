using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;
using Notifications.Model.Interfaces;
using Notifications.Services;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldNotificationsTaskHandler : TaskHandlerBase
    {
        public DeleteOldNotificationsTaskHandler(INotificationService notificationService, IBatchRequest batchRequest, IProgressNotification? progressNotification)
            : base(notificationService, batchRequest, progressNotification)
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
