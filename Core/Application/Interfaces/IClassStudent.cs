using Application.DTOs;
namespace Application.Interfaces
{
    public interface IClassStudent
    {
        Task<List<GetClassStudentDTO>> GetAllClassStudentsAsync();
        
        Task  AddClassStudentAsync(AddClassStudentDTO classStudent);
        Task <GetClassStudentDTO?> GetClassStudentByIdAsync(int id);
        Task UpdateClassStudentAsync(UpdateClassStudentDTO classStudent);
        Task DeleteClassStudentAsync(DeleteClassStudentDTO classStudent);
        
        }

   
}