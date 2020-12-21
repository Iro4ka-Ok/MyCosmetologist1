using Microsoft.Extensions.DependencyInjection;
using MyCosmetologist.Data.Core;
using MyCosmetologist.Data.Core.Interfaces;
using MyCosmetologist.Data.Repositories;
using MyCosmetologist.Data.Repositories.Interfaces;

namespace MyCosmetologist.Data
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddScoped<IContextFactory, ContextFactory>(provider => new ContextFactory(connectionString));

            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IProcedureCategoryRepository, ProcedureCategoryRepository>();
            services.AddTransient<IProcedureRepository, ProcedureRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IRecordRepository, RecordRepository>();
        }
    }
}