using BatchBuilder.Model.Interfaces;
using Notifications.Model.Interfaces;

namespace Batches.Model.Batches
{
    internal class EmailBatch : BatchBase
    {
        public EmailBatch(IBatchRequest request, TaskHandlerBase initialTask) : base(request, initialTask)
        {
        }

        internal override bool Run()
        {
            throw new NotImplementedException();
        }

        protected override void UpdateNotification(INotification notification)
        {
            throw new NotImplementedException();
        }
    }
}
