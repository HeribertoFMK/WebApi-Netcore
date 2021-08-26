using Api.Data.Repository;
using Api.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection iservicecolletion)
        {

            iservicecolletion.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));


        }
    }
}