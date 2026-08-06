using Domain.Entities;
using Domain.ValueObjects;
namespace Application.DTOs
{
    public class AddClassDTO
    {
        public int Id {get;set;}
        public string Name{get;set;}
       public int  EducationLevelId{get;set;}
       public int FacultyId{get;set;} 
    }
    public class UpdateClassDTO
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public int EducationLevelId{get;set;}
        public int FacultyId{get;set;}
    }
    public class GetClassDTO
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public int EducationLevelId{get;set;}
        public EducationLevel EducationLevel{get;set;}
        public int FacultyId{get;set;}
        public Faculty Faculty{get;set;}
        public ClassStatus Status{get;set;}

        }
        public class DeleteClassDTO
    {
         public int Id{get;set;}
        public string  Name{get;set;}
        public int EducationLevelId{get;set;}
        
        public int FacultyId{get;set;}
        
        
        
    }

    public class GetClassStatusCountDTO
    {
        public ClassStatus Status{get; set;}
        public int Count{get;set;}
    }
}