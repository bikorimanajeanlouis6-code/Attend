using Domain.Entities;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
        public List<Classs>GetAllClasses();
        
        public void AddClass(Classs classs);
    }
}