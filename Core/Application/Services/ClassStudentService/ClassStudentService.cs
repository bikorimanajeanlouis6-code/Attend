using Application.DTOs;
using Application.Interfaces;
namespace Application.Services.ClassStudentServices
{
    public class ClassStudentService : IClassStudentService
    {
        private readonly IClassStudent _classStudentRepository;
        public ClassStudentService(IClassStudent classStudentRepository)
        {
            _classStudentRepository = classStudentRepository;
        }
        public async Task AddClassStudentAsync(AddClassStudentDTO classStudent)
        {
            await _classStudentRepository.AddClassStudentAsync(classStudent);
        }

        public async Task DeleteClassStudentAsync(DeleteClassStudentDTO classStudent)
        {
            await _classStudentRepository.DeleteClassStudentAsync(classStudent);
        }

        public async Task<List<GetClassStudentDTO>> GetAllClassStudentAsync()
        {
            return await _classStudentRepository.GetAllClassStudentsAsync();
        }

        public async Task<GetClassStudentDTO?> GetClassStudentByIdAsync(int id)
        {
            return await _classStudentRepository.GetClassStudentByIdAsync(id);
        }

        public async Task UpdateClassStudentAsync(UpdateClassStudentDTO classStudent)
        {
            await _classStudentRepository.UpdateClassStudentAsync(classStudent);
        }
    }

}