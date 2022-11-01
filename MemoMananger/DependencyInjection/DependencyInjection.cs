using System.Runtime.CompilerServices;

namespace MemoMananger.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddMemoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IMemoService, MemoService>();
        }
    }
}
