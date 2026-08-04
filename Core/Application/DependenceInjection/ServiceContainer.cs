using Application.Services.ClassServices;
using Application.Services.AttendanceServices;
using Application.Services.StudentServices;
using Application.Services.EducationLevelServices;
using Microsoft.Extensions.DependencyInjection;
using Application.Services.ClassStudentServices;
using Application.Services.FacultyServices;
using Application.Services.StudentAttendanceServices;
using Domain.Entities;


namespace Application.DependenceInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this  IServiceCollection services)
        {
             services.AddScoped<IStudentService, StudentService>();
             services.AddScoped<IClassService, ClassService>();
             services.AddScoped<IAttendanceService, AttendanceService>();
             services.AddScoped<IEducationLevelService, EducationLevelService>();
             services.AddScoped<IClassStudentService, ClassStudentService>();
             services.AddScoped<IFacultyService, FacultyService>();
             services.AddScoped<IStudentAttendanceService, StudentAttendanceService>();
            return services;
        }

    }
}