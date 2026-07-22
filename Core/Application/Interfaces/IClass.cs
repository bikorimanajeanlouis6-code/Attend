using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IClass
{
    public List<GetClassDTO>GetAllClasses();

   public void AddClass(AddClassDTO classs);

  public GetClassDTO? GetClassById(int id);
  
  public void UpdateClass(UpdateClassDTO student);
  public void DeleteClass(DeleteClassDTO student);
}
    }