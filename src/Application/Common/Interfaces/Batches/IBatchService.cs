namespace Application.Common.Interfaces.Batches
{
    public interface IBatchService
    {
        bool StartMaintenanceBatch();
        bool StartEmailBatch(Domain.Entities.Memo memo);
    }
}
