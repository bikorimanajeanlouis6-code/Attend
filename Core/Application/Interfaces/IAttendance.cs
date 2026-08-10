using Application.DTOs;
namespace Application.Interfaces
{
    public interface IAttendance
    {
    Task<List<GetAttendanceDTO>> GetAllAttendanceAsync();
    
     Task AddAttendanceAsync(AddAttendanceDTO Attendance);
    Task<List<GetStudentAttendanceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendanceDTO attendance);

     Task <GetAttendanceDTO?> GetAttendanceByIdAsync(int id);
  
      // Task UpdateAttendanceAsync(UpdateAttendanceDTO Attendance);
 
      // Task DeleteAttendanceAsync(DeleteAttendanceDTO Attendance);

    }
} 


  