using BatchBuilder.Model.Interfaces;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldNotificationsTaskHandler : TaskHandlerBase
    {
        public DeleteOldNotificationsTaskHandler(IBatchRequest batchRequest) : base(batchRequest)
        {
        }

        internal override void Handle()
        {
            Console.WriteLine("Pretend I'm deleting old notifications from the database...");
        }
    }
}
