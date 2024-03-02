using Loteria.Simulador.Services;
using Loteria.Simulador.Services.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Loteria.Simulador.Infrastructure.Ioc
{
    public static class BootStrapper
    {
        public static void ConfigureContainer(IServiceCollection services)
        {
            ConfigureServices(services);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ILotoFacilService, LotoFacilService>();
            services.AddScoped<IMegaSenaService, MegaSenaService>();
            services.AddScoped<IQuinaService, QuinaService>();
        }
    }
}