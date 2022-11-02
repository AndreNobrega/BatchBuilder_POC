using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldNotificationsTaskHandler : TaskHandlerBase
    {
        public DeleteOldNotificationsTaskHandler(IBatchRequest batchRequest) : base(batchRequest)
        {
            TaskLogic = DeleteOldNotifications;
        }

        public void DeleteOldNotifications()
        {
            Console.WriteLine("Pretend I'm deleting old notifications...");
        }
    }
}
