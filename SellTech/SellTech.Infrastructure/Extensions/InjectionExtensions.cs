using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SellTech.Infrastructure.FileStorage;
using SellTech.Infrastructure.Persistences.Contexts;
using SellTech.Infrastructure.Persistences.Interfaces;
using SellTech.Infrastructure.Persistences.Repository;

namespace SellTech.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(BdPosContext).Assembly.FullName;

            services.AddDbContext<BdPosContext>(
                options => options.UseSqlServer(
                       configuration.GetConnectionString("POSConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IAzureStorage, AzureStorage>();

            return services;
        }
    }
}
