using Application.DTOs;
namespace Application.Interfaces
{
    public interface IAttendance
    {
    public   Task  <List<GetAttendanceDTO>> GetAllAttendanceAsync();
    
     Task AddAttendanceAsync(AddAttendanceDTO Attendance);

     Task <GetAttendanceDTO?> GetAttendanceByIdAsync(int id);
  
      Task UpdateAttendanceAsync(UpdateAttendanceDTO Attendance);
 
      Task DeleteAttendanceAsync(DeleteAttendanceDTO Attendance);

    }
} 


  