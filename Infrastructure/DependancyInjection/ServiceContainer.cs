
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Infrastructure.Identity;
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
            services.AddAuthenticationService(configuration);
            services.AddScoped<IStudent, StudentRepository>();
            services.AddScoped<IAttendance, AttendanceRepository>();
            services.AddScoped<IClass, ClassRepository>();
            services.AddScoped<IEducationLevel, EducationLevelRepository>();
            services.AddScoped<IClassStudent, ClassStudentRepository>();
            services.AddScoped<IFaculty, FacultyRepository>();
            services.AddScoped<IStudentAttendance, StudentAttendanceRepository>();
            services.AddScoped<IIdentity, IdentityRepository>();
            return services;
        }
    }
}