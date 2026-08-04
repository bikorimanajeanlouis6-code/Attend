using Application.DTOs;
namespace Application.Interfaces
{
    public interface IFaculty
    {
        Task<List<GetFacultyDTO>> GetAllFacultyAsync();
        
        Task  AddFacultyAsync(AddFacultyDTO faculty);
        Task <GetFacultyDTO?> GetFacultyByIdAsync(int id);
        Task UpdateFacultyAsync(UpdateFacultyDTO faculty);
        Task DeleteFacultyAsync(DeleteFacultyDTO faculty);
    }
}