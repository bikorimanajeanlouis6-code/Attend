using Application.DTOs;
using Application.Interfaces;
using Domain.ValueObjects;
namespace Application.Services.StudentAttendanceServices
{
    public interface IStudentAttendanceService
    {
        Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync();
       Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus status);
        Task <GetStudentAttendanceDTO?> GetStudentAttendanceByIdAsync(int id);
    //     Task UpdateStudentAttendanceAsync(UpdateStudentAttendanceDTO studentAttendance);
    //     Task DeleteStudentAttendanceAsync(DeleteStudentAttendanceDTO studentAttendance);
    //
    
     }

    
}
