using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.ClassServices
{
    public class ClassService:IClassService
    {
          private readonly IClass _classes;
         public ClassService(IClass classes)
        {
            _classes=classes;
        }  
         public List<Classs>GetAllClasses()
        {
            return _classes.GetAllClasses();
        }
        public void AddClass(Classs classs)
        {
            _classes.AddClass(classs);
        }
    }
}