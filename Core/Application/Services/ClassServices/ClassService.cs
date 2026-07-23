using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.ClassServices
{
    public class ClassService: IClassService
    {
          private readonly IClass _classes;
         public ClassService(IClass classes)
        {
            _classes=classes;
        }  
         public async Task<List<GetClassDTO>> GetAllClassesAsync()
        {
            return await _classes.GetAllClassesAsync();
        }
          public async Task<GetClassDTO?> GetClassByIdAsync(int id)
        {
            return await _classes.GetClassByIdAsync(id);
        }
        public async Task AddClassAsync(AddClassDTO classs)
        {
           await _classes.AddClassAsync(classs);
        }
         public async Task UpdateClassAsync(UpdateClassDTO classs)
        {
            await _classes.UpdateClassAsync(classs);
        }
        public async Task DeleteClassAsync(DeleteClassDTO classs)
        {
            await _classes.DeleteClassAsync(classs);
        }
    }
}