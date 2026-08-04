
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IStudentAttendance
    {
        Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync();
        Task AddStudentAttendanceAsync(AddStudentAttendanceDTO studentAttendance);
        Task <GetStudentAttendanceDTO?> GetStudentAttendanceByIdAsync(int id);
        Task UpdateStudentAttendanceAsync(UpdateStudentAttendanceDTO studentAttendance);
        Task DeleteStudentAttendanceAsync(DeleteStudentAttendanceDTO studentAttendance);
    }
}