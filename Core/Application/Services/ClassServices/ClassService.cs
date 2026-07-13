using Domain.Entities;
namespace Application.Services.ClassServices
{

    public class ClassService: IClassService
    {
         public List<Classs>GetAllClasses()
        {
            return new List<Classs>

            {
                new Classs {id=1, name="class s1", level="level 1", teacher="joy", student="student 1"},
            new Classs {id=2, name="class s2", level="level 2", teacher=" richard", student="student 2"} 
            };
           
        }
        
    }
}