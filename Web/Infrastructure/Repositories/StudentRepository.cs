using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class StudentRepositories: IStudent
{
    public List<Student>GetAllStudents()
    {
        return new List<Student>
        {
            
            new Student {Id=1, Email="bikorimana@gmail.com", Name="BIKORIMANA",Phone="07987987987",Sex="male", DateofBirth= new DateTime(2000,1,6)},
            new Student {Id=2, DateofBirth= new DateTime (2005, 4, 26), Email="bikirimana@gmail.com",Name="BIKORIMANA",Phone="078837578",Sex="MALE"}
        };
        }
    
    }
    
}

    

