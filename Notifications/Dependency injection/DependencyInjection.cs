using Microsoft.Extensions.DependencyInjection;

namespace Notifications.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddNotificationDependencies(this IServiceCollection services)
        {
            services.AddScoped<INotificationService, NotificationService>();
        }
    }
}
