﻿using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;

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

            _nextHandler?.Handle(); //todo: move this logic to the base class
        }
    }
}
