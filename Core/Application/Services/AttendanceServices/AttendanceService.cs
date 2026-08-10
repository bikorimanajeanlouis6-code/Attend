using Application.DTOs;
using Application.Interfaces;
namespace Application.Services.AttendanceServices
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendance _attendance;
        public AttendanceService(IAttendance attendance)
        {
            _attendance=attendance;
        }


        public async Task<List<GetAttendanceDTO>> GetAllAttendanceAsync()
        {
            return await _attendance.GetAllAttendanceAsync();
        }
          public async Task<GetAttendanceDTO?> GetAttendanceByIdAsync(int id)
        {
            return await _attendance.GetAttendanceByIdAsync(id);
        }
        public async Task AddAttendanceAsync(AddAttendanceDTO Attendance)
        {
           await _attendance.AddAttendanceAsync(Attendance);
        }
       
          public async Task<List<GetStudentAttendanceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendanceDTO attendance)
        {
            return await _attendance.AddAttendanceWithStudentAttendanceAsync(attendance);
        }

    }
}