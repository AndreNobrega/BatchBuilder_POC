using Batches.Model.BatchBuilders;
using Batches.Model.BatchBuilders.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Batches.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddBatchDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBatchService, BatchService>();
            services.AddScoped<BatchDirectorBase, BatchDirector>();

            services.AddScoped<IMaintenanceBatchBuilder, MaintenanceBatchBuilder>();
        }
    }
}
