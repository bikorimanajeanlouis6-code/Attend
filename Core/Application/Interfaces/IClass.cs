using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IClass
{
    public Task <List<GetClassDTO>> GetAllClassesAsync();

   public Task AddClassAsync(AddClassDTO classs);

  public Task <GetClassDTO?> GetClassByIdAsync(int id);
  
  public Task UpdateClassAsync(UpdateClassDTO student);
  public Task DeleteClassAsync(DeleteClassDTO student);
}
    }