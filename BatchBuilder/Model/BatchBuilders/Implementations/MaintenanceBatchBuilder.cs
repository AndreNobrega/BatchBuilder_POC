using Batches.Model.Batches;
using Batches.Model.Batches.Implementations;
using Batches.Model.BatchRequest;
using Batches.Model.BatchTasks.Maintenance;
using Notifications.Model.Interfaces;
using Notifications.Services;
using Serilog;

namespace Batches.Model.BatchBuilders.Implementations
{
    internal class MaintenanceBatchBuilder : IMaintenanceBatchBuilder
    {
        public BatchBase BuildBatch(ILogger logger, IBatchRequest request, INotificationService notificationService, IProgressNotification? progressNotification)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            var task1 = new DeleteOldLogFilesTaskHandler(notificationService, request, progressNotification);
            var task2 = new DeleteOldNotificationsTaskHandler(notificationService, request, progressNotification);
            var task3 = new DeleteSomethingElseTaskHandler(notificationService, request, progressNotification);

            task1.SetNext(task2).SetNext(task3);

            var maintenanceBatch = new MaintenanceBatch(logger, request, task1);
            return maintenanceBatch;
        }
    }
}
