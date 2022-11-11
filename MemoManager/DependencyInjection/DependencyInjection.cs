using MemoManager.Controllers;
using MemoManager.Services;

namespace MemoManager.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddMemoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IMemoService, MemoService>();
            services.AddScoped<ITestController, TestController>();
        }
    }
}
