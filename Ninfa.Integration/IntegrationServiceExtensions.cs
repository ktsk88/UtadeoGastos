using Microsoft.Extensions.DependencyInjection;

using Ninfa.Interface;

namespace Ninfa.Integration
{
    public static class IntegrationServiceExtensions
    {
        public static IServiceCollection AddNinfaIntegrations(this IServiceCollection services)
        {
            services.AddScoped<IGptCommunication, GptCommunication>();
            return services;
        }
    }
}
