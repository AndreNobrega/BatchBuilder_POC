using Batches.Model.Batches;
using Batches.Model.Batches.Implementations;
using Batches.Model.BatchRequest;
using Batches.Model.BatchTasks.Maintenance;
using Notifications.Services;
using Serilog;

namespace Batches.Model.BatchBuilders.Implementations
{
    internal class MaintenanceBatchBuilder : IMaintenanceBatchBuilder
    {
        private const string _notificationTitle = "Maintenance";
        private const string _notificationMessage = "Creating maintenance batch...";

        public BatchBase BuildBatch(ILogger logger, IBatchRequest request, INotificationService notificationService)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            var progressNotification = notificationService.CreateProgressNotification(_notificationTitle, _notificationMessage);

            var task1 = new DeleteOldLogFilesTaskHandler(request, notificationService, progressNotification);
            var task2 = new DeleteOldNotificationsTaskHandler(request, notificationService, progressNotification);
            var task3 = new DeleteSomethingElseTaskHandler(request, notificationService, progressNotification);

            task1.SetNext(task2).SetNext(task3);

            var maintenanceBatch = new MaintenanceBatch(logger, request, task1);
            return maintenanceBatch;
        }
    }
}
