
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using BlogSistemi.Service.Services;


namespace BlogSistemi.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IPostService, PostService>();
            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
