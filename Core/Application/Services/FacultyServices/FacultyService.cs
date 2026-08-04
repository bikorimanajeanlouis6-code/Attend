using Application.DTOs;
using Application.Interfaces;
namespace Application.Services.FacultyServices
{
    public class FacultyService : IFacultyService
    {
        private readonly IFaculty _faculty;
        public FacultyService(IFaculty faculty)
        {
            _faculty=faculty;
        }
        public async Task<List<GetFacultyDTO>> GetAllFacultyAsync()
        {
            return await _faculty.GetAllFacultyAsync();
        }
         public async Task  AddFacultyAsync(AddFacultyDTO faculty)
        {
            await _faculty.AddFacultyAsync(faculty);
        }
         public async Task <GetFacultyDTO?> GetFacultyByIdAsync(int id)
        {
            return await _faculty.GetFacultyByIdAsync(id);
        }
         public async Task  UpdateFacultyAsync(UpdateFacultyDTO faculty)
        {
            await _faculty.UpdateFacultyAsync(faculty);
        }
        public async Task DeleteFacultyAsync(DeleteFacultyDTO faculty)
        {
             await _faculty.DeleteFacultyAsync(faculty);
        }
    }
}