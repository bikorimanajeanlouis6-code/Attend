using Domain.Entities;
namespace Application.Services.ClassServices
{

    public class ClassService: IClassService
    {
         public List<Classs>GetAllClasses()
        {
            return new List<Classs>

            {
            new Classs {Id=1, Name="class s1", EducationLevelId=" 1",  Faculty="IT"},
            new Classs {Id=2, Name="class s2", EducationLevelId=" 2", Faculty=" ICT",} 
            };
           
        }
        
    }
}