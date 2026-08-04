
using Application.DTOs;
namespace Application.Services.StudentAttendanceServices
{
    public interface IStudentAttendanceService
    {
        Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync();
        Task AddStudentAttendanceAsync(AddStudentAttendanceDTO studentAttendance);
        Task <GetStudentAttendanceDTO?> GetStudentAttendanceByIdAsync(int id);
        Task UpdateStudentAttendanceAsync(UpdateStudentAttendanceDTO studentAttendance);
        Task DeleteStudentAttendanceAsync(DeleteStudentAttendanceDTO studentAttendance);
    }

    
}