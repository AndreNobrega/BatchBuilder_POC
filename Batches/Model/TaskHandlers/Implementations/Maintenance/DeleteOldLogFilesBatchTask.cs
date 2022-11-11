using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;
using Notifications.Model.Interfaces;
using Notifications.Services;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldLogFilesTaskHandler : TaskHandlerBase
    {
        public DeleteOldLogFilesTaskHandler(IBatchRequest batchRequest, INotificationService notificationService, IProgressNotification? progressNotification) 
            : base(batchRequest, notificationService, progressNotification)
        {
            TaskLogic = DeleteOldLogFiles;
        }

        protected override string NotificationMessage => "Deleting old log files...";

        private void DeleteOldLogFiles()
        {
            Console.WriteLine("Pretend I'm deleting old log files...");
        }
    }
}
