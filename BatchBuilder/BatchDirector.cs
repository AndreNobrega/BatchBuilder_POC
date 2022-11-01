using BatchBuilder.Model.Interfaces;
using Batches.Model.BatchBuilders;
using Batches.Model.Batches;

namespace Batches
{
    internal class BatchDirector : BatchDirectorBase
    {
        private readonly IMaintenanceBatchBuilder _maintenanceBatchBuilder;

        public BatchDirector(IMaintenanceBatchBuilder maintenanceBatchBuilder)
        {
            _maintenanceBatchBuilder = maintenanceBatchBuilder;
        }

        internal override BatchBase BuildBatch(IBatchRequest request)
        {
            return request.BatchType switch
            {
                BatchBuilder.Model.Enums.BatchType.Email => BuildEmailBatch(request),
                BatchBuilder.Model.Enums.BatchType.Maintenance => BuildMaintenanceBatch(request),
                _ => throw new NotImplementedException("Batch type is currently not implemented"),
            };
        }

        private EmailBatch BuildEmailBatch(IBatchRequest request)
        {
            throw new NotImplementedException();
        }

        private MaintenanceBatch BuildMaintenanceBatch(IBatchRequest request)
        {
            return (MaintenanceBatch) _maintenanceBatchBuilder.BuildBatch(request);
        }
    }
}
