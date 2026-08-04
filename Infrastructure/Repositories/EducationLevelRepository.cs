using Domain.Entities;

using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
     public class EducationLevelRepository : IEducationLevel
    {
        private readonly ApplicationDbContext _dbcontext;

       

        public EducationLevelRepository(ApplicationDbContext dbcontext)
        {
              _dbcontext= dbcontext;
           
        }
         public async Task<List<GetEducationLevelDTO>> GetAllEducationLevelAsync()
        {
            return await _dbcontext.EducationLevels.Select(s=> new GetEducationLevelDTO
            {                  
                Id =s.Id,
                Name =s.Name,
                Status=s.Status,
                DateAdded=s.DateAdded,
                UserAdded=s.UserAdded

            }).ToListAsync();
        }

         public async Task AddEducationLevelAsync(AddEducationLevelDTO educationLevel)
        {
            _ = _dbcontext.EducationLevels.Add(new EducationLevel
            {

                Id = educationLevel.Id,
                Name = educationLevel.Name,
                UserAdded = "Admin",
                DateAdded = DateTime.UtcNow,
                Status = "Active"

            });
            await _dbcontext.SaveChangesAsync();    
        }
         public async Task<GetEducationLevelDTO?> GetEducationLevelByIdAsync(int id)
        {
             return await  _dbcontext.EducationLevels.Where(s => s.Id == id).Select(s=> new GetEducationLevelDTO
             {
                  Id =s.Id,
                Name =s.Name,
                Status=s.Status,
                DateAdded=s.DateAdded,
                UserAdded=s.UserAdded
                
                }).FirstOrDefaultAsync();   
        }

         public async Task UpdateEducationLevelAsync(UpdateEducationLevelDTO educationLevel)
        {
             var ExistingEducationLevel = await _dbcontext.EducationLevels.FirstOrDefaultAsync(s => s.Id == educationLevel.Id);
             if(ExistingEducationLevel != null)
            {
                 ExistingEducationLevel.Name = educationLevel.Name;
                 ExistingEducationLevel.Status = educationLevel.Status;
                 ExistingEducationLevel.UserAdded = educationLevel.UserAdded;
                 ExistingEducationLevel.DateAdded = educationLevel.DateAdded;


                  await _dbcontext.SaveChangesAsync();
            }
        }
         public async Task DeleteEducationLevelAsync(DeleteEducationLevelDTO educationLevel)
        {
            var ExistingEducationLevel = await _dbcontext.Students.FirstOrDefaultAsync(s => s.Id == educationLevel.Id);
            if(ExistingEducationLevel != null)
            {
               
                await _dbcontext.SaveChangesAsync();
            }
        }
    }
}
