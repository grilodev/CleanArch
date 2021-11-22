using Application.Interfaces;
using Application.Services;
using Data.Context;
using Data.Repositories;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
            
            services.AddDatabaseDeveloperPageExceptionFilter();
            
            services.AddScoped<IAnuncioRepository, AnuncioRepository>();
            services.AddScoped<IAnuncioService, AnuncioService>();

            return services;
        }
    }
}
