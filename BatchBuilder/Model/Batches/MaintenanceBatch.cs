using BatchBuilder.Model.Interfaces;
using Notifications.Model.Interfaces;

namespace Batches.Model.Batches
{
    internal class MaintenanceBatch : BatchBase
    {
        public MaintenanceBatch(IBatchRequest request, TaskHandlerBase initialTask) : base(request, initialTask)
        {
        }
    }
}
