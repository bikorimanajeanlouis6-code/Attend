using Domain.Entities;
using Application.DTOs;
using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
namespace Infrastructure.Repositories
{
    public class ClassRepository : IClass
    {
          private readonly ApplicationDbContext _dbcontext;
           public ClassRepository(ApplicationDbContext dbcontext)
        {
              _dbcontext= dbcontext;
            
    }
     public async Task <List<GetClassDTO>> GetAllClassesAsync()
        {
           
             return await _dbcontext.Classses

             .Include(s => s.Faculty)
             .Include(s => s.EducationLevel)
             .Select(s => new GetClassDTO
            {

               Id = s.Id, 
               Name=s.Name,
               Faculty= s.Faculty,
               EducationLevel= s.EducationLevel,
               FacultyId=s.FacultyId,
               EducationLevelId=s.EducationLevelId

              })
              .ToListAsync();
           
        }
        public async Task AddClassAsync(AddClassDTO classs)
        {
                var existingClass = await _dbcontext.Classses.AnyAsync(c=> c.Name == classs.Name && c.FacultyId ==classs.FacultyId && c.EducationLevelId ==classs.EducationLevelId);
                if (existingClass)
            {
               throw new InvalidCastException( "A Class and Faculty is already exit") ;
            }
             

                _dbcontext.Classses.Add(new Classs
                {
                    Name = classs.Name,
                    FacultyId = classs.FacultyId,
                    EducationLevelId = classs.EducationLevelId
                });
              await  _dbcontext.SaveChangesAsync();
        }

        public async Task<GetClassDTO?> GetClassByIdAsync(int id)
        {
            return await _dbcontext.Classses
            .Include(s => s.Faculty)
            .Include(s=> s.EducationLevel)
            .Where(s => s.Id == id).Select(s => new GetClassDTO
            {
              Id = s.Id,
              Name = s.Name,
              Faculty= s.Faculty,
              EducationLevel= s.EducationLevel,
              FacultyId = s.FacultyId,
              EducationLevelId = s.EducationLevelId

             }).FirstOrDefaultAsync();
        }
        public async Task UpdateClassAsync(UpdateClassDTO classs)
        {
             var ExistingClass =  _dbcontext.Classses.FirstOrDefault(s => s.Id == classs.Id);
             if(ExistingClass != null)
             {
                 ExistingClass.Name = classs.Name;
                 ExistingClass.FacultyId = classs.FacultyId;
                 ExistingClass.EducationLevelId = classs.EducationLevelId;
                 await _dbcontext.SaveChangesAsync();
             }
        }
        public async Task DeleteClassAsync(DeleteClassDTO classs)
        {
             var ExistingClass =  _dbcontext.Classses.FirstOrDefault(s => s.Id == classs.Id);
             if(ExistingClass != null)
             {
                 _dbcontext.Classses.Remove(ExistingClass);
                 await _dbcontext.SaveChangesAsync();
             }
        }
    }
}