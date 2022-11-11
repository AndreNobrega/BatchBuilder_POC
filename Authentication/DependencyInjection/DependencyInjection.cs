using Authentication.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddAuthenticationDependencies(this IServiceCollection services)
        {
            services.AddScoped<AuthenticationServiceBase, FirebaseAuthenticationService>();
        }
    }
}
