using Application.DTOs;
namespace Application.Services.FacultyServices
{
    public interface IFacultyService
    {
        Task <List<GetFacultyDTO>> GetAllFacultyAsync();
        Task AddFacultyAsync(AddFacultyDTO faculty);
        Task <GetFacultyDTO?> GetFacultyByIdAsync(int id);
         Task UpdateFacultyAsync (UpdateFacultyDTO faculty);
         Task DeleteFacultyAsync( DeleteFacultyDTO faculty);
    }
}