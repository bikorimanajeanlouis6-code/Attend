using Application.Interfaces;
using Domain.Entities;
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
         public List<GetClassDTO>GetAllClasses()
        {
            return _classes.GetAllClasses();
        }
          public GetClassDTO? GetClassById(int id)
        {
            return _classes.GetClassById(id);
        }
        public void AddClass(AddClassDTO classs)
        {
            _classes.AddClass(classs);
        }
         public void UpdateClass(UpdateClassDTO classs)
        {
            _classes.UpdateClass(classs);
        }
        public void DeleteClass(DeleteClassDTO classs)
        {
            _classes.DeleteClass(classs);
        }
    }
}