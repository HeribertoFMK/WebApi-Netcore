using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Interface.Services.User;
using Api.Service.Services;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();


        }
    }
}