using Application.DTOs;
namespace Application.Services.AttendanceServices
{
    public interface IAttendanceService
    {
           Task <List<GetAttendanceDTO>>GetAllAttendanceAsync();
           Task AddAttendanceAsync(AddAttendanceDTO Attendance); 
           Task <GetAttendanceDTO?> GetAttendanceByIdAsync(int id);
           Task UpdateAttendanceAsync(UpdateAttendanceDTO Attendance);
           Task DeleteAttendanceAsync(DeleteAttendanceDTO Attendance);
    }
}