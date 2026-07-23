using Domain.Entities;
using Application.DTOs;
using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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
            return await _dbcontext.Classses.Select(s => new GetClassDTO
            {
               Id = s.Id, 
               Name=s.Name,
               FacultyId=s.FacultyId,
               EducationLevelId=s.EducationLevelId

              })
              .ToListAsync();
           
        }
        public async Task AddClassAsync(AddClassDTO classs)
        {
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
            return await _dbcontext.Classses.Where(s => s.Id == id).Select(s => new GetClassDTO
            {
              Id = s.Id,
              Name = s.Name,
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