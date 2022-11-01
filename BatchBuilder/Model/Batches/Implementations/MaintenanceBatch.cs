using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;
using Serilog;

namespace Batches.Model.Batches.Implementations
{
    internal class MaintenanceBatch : BatchBase
    {
        public MaintenanceBatch(ILogger logger, IBatchRequest request, TaskHandlerBase initialTask) : base(logger, request, initialTask)
        {
        }
    }
}
