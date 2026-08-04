using Domain.Entities;

using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
     public class FacultyRepository : IFaculty
    {
        private readonly ApplicationDbContext _dbcontext;
        public FacultyRepository(ApplicationDbContext dbcontext) 
        {
            _dbcontext = dbcontext;
        }
         public async Task<List<GetFacultyDTO>> GetAllFacultyAsync()
        {
            return await _dbcontext.Faculties.Select(f=> new GetFacultyDTO
            {
                Id = f.Id,
                Name = f.Name
            }).ToListAsync();
        }
         public async Task AddFacultyAsync(AddFacultyDTO faculty)
        {
             _dbcontext.Faculties.Add(new Faculty
                {
                    Name = faculty.Name
               }  );
            await _dbcontext.SaveChangesAsync();
        }
         public async Task<GetFacultyDTO?> GetFacultyByIdAsync(int id)
        {
            return await _dbcontext.Faculties.Where(f => f.Id == id).Select(f=> new GetFacultyDTO
            {
                Id = f.Id,
                Name = f.Name
            }).FirstOrDefaultAsync();
        }
         public async Task UpdateFacultyAsync(UpdateFacultyDTO faculty)
        {
             var ExistingFaculty =  _dbcontext.Faculties.FirstOrDefault(f => f.Id == faculty.Id);
             if(ExistingFaculty != null)
             {
                 ExistingFaculty.Name = faculty.Name;
                 
                 await _dbcontext.SaveChangesAsync();
             }
        }
        public async Task DeleteFacultyAsync(DeleteFacultyDTO faculty)
        {
             var ExistingFaculty =  _dbcontext.Faculties.FirstOrDefault(f => f.Id == faculty.Id);
             if(ExistingFaculty != null)
             {
                 _dbcontext.Faculties.Remove(ExistingFaculty);
                 await _dbcontext.SaveChangesAsync();
             }
            }
    }
}
