using Application.Interfaces;
using Application.DTOs;
using Domain.ValueObjects;
namespace Application.Services.StudentAttendanceServices
{
    public class StudentAttendanceService : IStudentAttendanceService
    {
        private readonly IStudentAttendance _studentAttendance;
        public StudentAttendanceService(IStudentAttendance studentAttendance)
        {
            _studentAttendance=studentAttendance;
        }
        public async Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync()
        {
            return await _studentAttendance.GetAllStudentAttendancesAsync();
        }
          public async Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus status)
        {
            await _studentAttendance.AddStudentAttendanceAsync(AttendanceId, status);
        }
         public async Task <GetStudentAttendanceDTO?> GetStudentAttendanceByIdAsync(int id)
        {
            return await _studentAttendance.GetStudentAttendanceByIdAsync(id);
        }
        //  public async Task  UpdateStudentAttendanceAsync(UpdateStudentAttendanceDTO studentAttendance)
        // {
        //     await _studentAttendance.UpdateStudentAttendanceAsync(studentAttendance);
        // }
        //  public async Task DeleteStudentAttendanceAsync(DeleteStudentAttendanceDTO student)
        // {
        //      await _studentAttendance.DeleteStudentAttendanceDTO(student);
        // }
    }
}