
using Application.DTOs;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
           Task <List<GetClassDTO>>GetAllClassesAsync();
          Task AddClassAsync(AddClassDTO classs);
         Task <GetClassDTO?> GetClassByIdAsync(int id);
         Task UpdateClassAsync(UpdateClassDTO classs);
        Task DeleteClassAsync(DeleteClassDTO classs);

    }
}