using Microsoft.Extensions.DependencyInjection;
using Ninfa.Logic.Abstractions.Interface;

namespace Ninfa.Logic
{
    public static class LogicServiceExtensions
    {
        public static IServiceCollection AddNinfaLogic(this IServiceCollection services)
        {
            services.AddScoped<IUsserLogic, UsserLogic>();
            return services;
        }
    }
}
