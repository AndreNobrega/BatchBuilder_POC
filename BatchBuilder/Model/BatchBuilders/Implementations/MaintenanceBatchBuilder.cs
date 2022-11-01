using Batches.Model.Batches;
using Batches.Model.BatchRequest;
using Batches.Model.BatchTasks.Maintenance;

namespace Batches.Model.BatchBuilders.Implementations
{
    internal class MaintenanceBatchBuilder : IMaintenanceBatchBuilder
    {
        public BatchBase BuildBatch(IBatchRequest request)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            var task1 = new DeleteOldLogFilesTaskHandler(request);
            var task2 = new DeleteOldNotificationsTaskHandler(request);
            var task3 = new DeleteSomethingElseTaskHandler(request);

            task1.SetNext(task2).SetNext(task3);

            var maintenanceBatch = new MaintenanceBatch(request, task1);
            return maintenanceBatch;
        }
    }
}
