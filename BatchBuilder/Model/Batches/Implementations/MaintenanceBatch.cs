using Batches.Model.BatchRequest;
using Batches.Model.TaskHandlers;
using Notifications.Model.Interfaces;

namespace Batches.Model.Batches.Implementations
{
    internal class MaintenanceBatch : BatchBase
    {
        public MaintenanceBatch(IBatchRequest request, TaskHandlerBase initialTask) : base(request, initialTask)
        {
        }
    }
}
