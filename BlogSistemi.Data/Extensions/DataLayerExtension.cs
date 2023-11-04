using BlogSistemi.Data.Repositories.Abstract;
using BlogSistemi.Data.Repositories.Concrete;
using BlogSistemi.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Data.Extensions
{
    public static class DataLayerExtension
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
