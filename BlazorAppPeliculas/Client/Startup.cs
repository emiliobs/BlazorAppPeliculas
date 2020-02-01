using Blazor.FileReader;
using BlazorAppPeliculas.Client.Repositorios;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorAppPeliculas.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ServiciosSingleton>();
            services.AddTransient<ServicioTransient>();
            services.AddScoped<IPeliculaRepositorio, PeliculaRepositorio>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
