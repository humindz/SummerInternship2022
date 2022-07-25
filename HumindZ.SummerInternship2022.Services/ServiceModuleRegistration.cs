using HumindZ.SummerInternship2022.Services.User;

using Microsoft.Extensions.DependencyInjection;

namespace HumindZ.SummerInternship2022.Services
{
    public static class ServiceModuleRegistration
    {
        public static void AddServiceModule(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
        }
    }
}
