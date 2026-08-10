
using Application.DTOs;
using Domain.ValueObjects;

namespace Application.Interfaces
{
    public interface IStudentAttendance
    {
        Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync();
         Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus status);
        Task <GetStudentAttendanceDTO?> GetStudentAttendanceByIdAsync(int id);
        // Task UpdateStudentAttendanceAsync(UpdateStudentAttendanceDTO studentAttendance);
        // Task DeleteStudentAttendanceDTO(DeleteStudentAttendanceDTO studentAttendance);
        }
}