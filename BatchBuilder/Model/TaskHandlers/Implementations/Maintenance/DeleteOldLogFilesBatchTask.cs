using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;
using Notifications.Model.Interfaces;
using Notifications.Services;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldLogFilesTaskHandler : TaskHandlerBase
    {
        public DeleteOldLogFilesTaskHandler(INotificationService notificationService, IBatchRequest batchRequest, IProgressNotification? progressNotification) 
            : base(notificationService, batchRequest, progressNotification)
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
