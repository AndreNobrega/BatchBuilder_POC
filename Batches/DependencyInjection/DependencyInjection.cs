using Batches.Model.BatchBuilders;
using Batches.Model.BatchBuilders.Implementations;
using Batches.Services;
using Batches.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Batches.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddBatchDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBatchService, BatchService>();
            services.AddScoped<BatchBuilderDirectorBase, BatchBuilderDirector>();

            services.AddScoped<IMaintenanceBatchBuilder, MaintenanceBatchBuilder>();
        }
    }
}
