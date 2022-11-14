using Application.Common.Interfaces.Notifications;
using Serilog;

namespace Application.Common.Interfaces.Batches
{
    internal interface IBatchBuilder
    {
        public BatchBase BuildBatch(ILogger logger, IBatchRequest request, INotificationService notificationService);
    }
}
