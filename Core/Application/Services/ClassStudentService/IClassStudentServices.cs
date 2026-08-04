using Application.DTOs;
namespace Application.Services.ClassStudentServices
{
    public interface IClassStudentService
    {
        Task<List<GetClassStudentDTO>> GetAllClassStudentAsync();
        Task AddClassStudentAsync(AddClassStudentDTO classStudent);
        Task <GetClassStudentDTO?> GetClassStudentByIdAsync(int id);
         Task UpdateClassStudentAsync (UpdateClassStudentDTO classStudent);
         Task DeleteClassStudentAsync( DeleteClassStudentDTO classStudent);
    }
}