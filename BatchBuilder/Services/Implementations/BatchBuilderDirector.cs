using Batches.Model.BatchBuilders;
using Batches.Model.Batches;
using Batches.Model.Batches.Implementations;
using Batches.Model.BatchRequest;

namespace Batches.Services.Implementations
{
    internal class BatchBuilderDirector : BatchBuilderDirectorBase
    {
        private readonly IMaintenanceBatchBuilder _maintenanceBatchBuilder;

        public BatchBuilderDirector(IMaintenanceBatchBuilder maintenanceBatchBuilder)
        {
            _maintenanceBatchBuilder = maintenanceBatchBuilder;
        }

        internal override BatchBase BuildBatch(IBatchRequest request)
        {
            return request.BatchType switch
            {
                BatchBuilder.Model.Enums.BatchType.Email => BuildEmailBatch(request),
                BatchBuilder.Model.Enums.BatchType.Maintenance => BuildMaintenanceBatch(request),
                _ => throw new NotImplementedException($"Batch type \"{request.BatchType}\" is currently not implemented."),
            };
        }

        private EmailBatch BuildEmailBatch(IBatchRequest request)
        {
            throw new NotImplementedException();
        }

        private MaintenanceBatch BuildMaintenanceBatch(IBatchRequest request)
        {
            return (MaintenanceBatch)_maintenanceBatchBuilder.BuildBatch(request);
        }
    }
}
