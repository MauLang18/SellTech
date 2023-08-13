using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SellTech.Application.Extensions.WatchDog;
using SellTech.Application.Interfaces;
using SellTech.Application.Services;
using System.Reflection;

namespace SellTech.Application.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);

            /*services.AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies().Where(p => !p.IsDynamic));
            });*/

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<ICategoriaApplication, CategoriaApplication>();
            services.AddScoped<IUsuarioApplication, UsuarioApplication>();
            services.AddScoped<IProveedorApplication, ProveedorApplication>();
            services.AddScoped<IAuthApplication, AuthApplication>();

            services.AddWatchDog();

            return services;
        }
    }
}
