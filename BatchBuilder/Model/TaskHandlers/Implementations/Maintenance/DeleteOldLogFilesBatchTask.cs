using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;

namespace Batches.Model.BatchTasks.Maintenance
{
    internal class DeleteOldLogFilesTaskHandler : TaskHandlerBase
    {
        public DeleteOldLogFilesTaskHandler(IBatchRequest batchRequest) : base(batchRequest)
        {
            TaskLogic = DeleteOldLogFiles;
        }

        private void DeleteOldLogFiles()
        {
            Console.WriteLine("Pretend I'm deleting old log files...");
        }
    }
}
