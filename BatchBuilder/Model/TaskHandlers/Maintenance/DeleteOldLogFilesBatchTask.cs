using BatchBuilder.Model.Interfaces;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldLogFilesTaskHandler : TaskHandlerBase
    {
        public DeleteOldLogFilesTaskHandler(IBatchRequest batchRequest) : base(batchRequest)
        {
        }

        internal override void Handle()
        {
            Console.WriteLine("Let's pretend I'm looking for log files, and cleaning them up");
        }
    }
}
