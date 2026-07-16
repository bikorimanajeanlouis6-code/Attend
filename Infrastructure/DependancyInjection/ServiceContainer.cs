
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Infrastructure.Repositories;

namespace Infrastructure.DependancyInjection
{
    public static class ServiceContainer
    {
      public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ATTENDCON"))
            );

            services.AddScoped<IStudent, StudentRepository>();
            // services.AddScoped<IClass, ClassRepostories>();
            return services;
        }
    }
}