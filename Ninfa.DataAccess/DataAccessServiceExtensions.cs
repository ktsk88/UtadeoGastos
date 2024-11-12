using Microsoft.Extensions.DependencyInjection;

using Ninfa.Interface;

namespace Ninfa.DataAccess
{
    public static class DataAccessServiceExtensions
    {
        public static IServiceCollection AddNinfaDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IConcepUserRepo, ConcepUserRepo>();
            services.AddScoped<IRegisterDataUser, RegisterDataUser>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IConversationRepo, ConversationRepo>();
            return services;
        }
    }
}
