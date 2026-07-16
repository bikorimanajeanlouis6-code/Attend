using Application.Services.StudentServices;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependenceInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this  IServiceCollection services)
        {
             services.AddScoped<IStudentService, StudentService>();
            return services;
        }

       
    }
}