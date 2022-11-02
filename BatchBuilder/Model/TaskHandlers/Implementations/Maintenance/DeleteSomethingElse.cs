using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteSomethingElseTaskHandler : TaskHandlerBase
    {
        public DeleteSomethingElseTaskHandler(IBatchRequest batchRequest) : base(batchRequest)
        {
            TaskLogic = DeleteSomethingElse;
        }

        private void DeleteSomethingElse()
        {
            Console.WriteLine("Pretend I'm deleting something else...");
        }
    }
}
