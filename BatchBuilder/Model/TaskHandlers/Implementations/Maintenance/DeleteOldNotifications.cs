using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;

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

            _nextHandler?.Handle(); //todo: move this logic to the base class
        }
    }
}
