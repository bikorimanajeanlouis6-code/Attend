using Domain.Entities;
using Application.DTOs;
using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class ClassRepository : IClass
    {
          private readonly ApplicationDbContext _dbcontext;
           public ClassRepository(ApplicationDbContext dbcontext)
        {
              _dbcontext= dbcontext;
            
    }
     public List<GetClassDTO> GetAllClasses()
        {
            return _dbcontext.Classses.Select(s => new GetClassDTO
            {
               Id = s.Id, 
               Name=s.Name,
               FacultyId=s.FacultyId,
               EducationLevelId=s.EducationLevelId

              })
              .ToList();
           
        }
        public void AddClass(AddClassDTO classs)
        {
                _dbcontext.Classses.Add(new Classs
                {
                    Name = classs.Name,
                    FacultyId = classs.FacultyId,
                    EducationLevelId = classs.EducationLevelId
                });
                _dbcontext.SaveChanges();
        }

        public GetClassDTO? GetClassById(int id)
        {
            return _dbcontext.Classses.Where (s => s.Id == id).Select(s => new GetClassDTO

            {
              Id = s.Id,
              Name = s.Name,
              FacultyId = s.FacultyId,
              EducationLevelId = s.EducationLevelId

             }).FirstOrDefault();
        }
        public void UpdateClass(UpdateClassDTO classs)
        {
             var ExistingClass =  _dbcontext.Classses.FirstOrDefault(s => s.Id == classs.Id);
             if(ExistingClass != null)
             {
                 ExistingClass.Name = classs.Name;
                 ExistingClass.FacultyId = classs.FacultyId;
                 ExistingClass.EducationLevelId = classs.EducationLevelId;
                 _dbcontext.SaveChanges();
             }
        }
        public void DeleteClass(DeleteClassDTO classs)
        {
             var ExistingClass =  _dbcontext.Classses.FirstOrDefault(s => s.Id == classs.Id);
             if(ExistingClass != null)
             {
                 _dbcontext.Classses.Remove(ExistingClass);
                 _dbcontext.SaveChanges();
             }
        }
    }
}