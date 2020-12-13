using Microsoft.Extensions.DependencyInjection;
using MyCosmetologist.Services.Services;
using MyCosmetologist.Services.Services.Interfaces;

namespace MyCosmetologist.Services
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            Data.Startup.ConfigureServices(services, connectionString);

            services.AddTransient<IProcedureService, ProcedureService>();
            services.AddTransient<IProcedureCategoryService, ProcedureCategoryService>();
        }
    }
}