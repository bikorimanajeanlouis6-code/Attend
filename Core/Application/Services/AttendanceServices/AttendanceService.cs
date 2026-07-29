using Application.DTOs;
using Application.Interfaces;
namespace Application.Services.AttendanceServices
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendance _Attendance ;

        public async Task<List<GetAttendanceDTO>> GetAllAttendanceAsync()
        {
            return await _Attendance.GetAllAttendanceAsync();
        }
          public async Task<GetAttendanceDTO?> GetAttendanceByIdAsync(int id)
        {
            return await _Attendance.GetAttendanceByIdAsync(id);
        }
        public async Task AddAttendanceAsync(AddAttendanceDTO Attendance)
        {
           await _Attendance.AddAttendanceAsync(Attendance);
        }
         public async Task UpdateAttendanceAsync(UpdateAttendanceDTO Attendance)
        {
            await _Attendance.UpdateAttendanceAsync(Attendance);
        }
        public async Task DeleteAttendanceAsync(DeleteAttendanceDTO Attendance)
        {
            await _Attendance.DeleteAttendanceAsync(Attendance);
        }
   

    }
}