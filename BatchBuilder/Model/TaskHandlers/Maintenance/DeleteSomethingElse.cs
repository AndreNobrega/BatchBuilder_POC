using BatchBuilder.Model.Interfaces;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteSomethingElseTaskHandler : TaskHandlerBase
    {
        public DeleteSomethingElseTaskHandler(IBatchRequest batchRequest) : base(batchRequest)
        {
        }

        internal override void Handle()
        {
            Console.WriteLine("Pretend I'm deleting something else...");
        }
    }
}
