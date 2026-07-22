using Domain.Entities;
using Application.DTOs;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
         public List<GetClassDTO>GetAllClasses();
         public void AddClass(AddClassDTO classs);
         public GetClassDTO? GetClassById(int id);
         public void UpdateClass(UpdateClassDTO classs);
         public void DeleteClass(DeleteClassDTO classs);

    }
}