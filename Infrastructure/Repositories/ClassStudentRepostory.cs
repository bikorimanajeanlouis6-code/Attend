using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories

{
   public class ClassStudentRepository : IClassStudent
    {
        private readonly ApplicationDbContext _dbcontext;
        public ClassStudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
         public async Task<List<GetClassStudentDTO>> GetAllClassStudentsAsync()
        {
            return await _dbcontext.ClassStudents
            .Include(s => s.Classs)
            .Include(s => s.Student)
            .Select(s => new GetClassStudentDTO
            {
                Id = s.Id,
                ClasssId = s.ClasssId,
                Classs=s.Classs,
                Student = s.Student,
                Status=s.Status,
                StudentId = s.StudentId,
                DateAdded = s.DateAdded,
                UserAdded = s.UserAdded

            }).ToListAsync();
        }
         public async Task AddClassStudentAsync(AddClassStudentDTO classStudent)
        {
             _dbcontext.ClassStudents.Add(new ClassStudent
            {
                ClasssId = classStudent.ClasssId,
                StudentId = classStudent.StudentId,
                UserAdded = "Admin",
                Status="Active",
                DateAdded = DateTime.UtcNow

            });
            await _dbcontext.SaveChangesAsync();
        }
         public async Task<GetClassStudentDTO?> GetClassStudentByIdAsync(int id)
        {
             return await _dbcontext.ClassStudents.Where(s => s.Id == id).Select(s => new GetClassStudentDTO
             {
                 Id = s.Id,
                 ClasssId = s.ClasssId,
                 StudentId = s.StudentId,
                 DateAdded = s.DateAdded,
                 UserAdded = s.UserAdded

             }).FirstOrDefaultAsync();
        }
         public async Task UpdateClassStudentAsync(UpdateClassStudentDTO classStudent)
        {
             var ExistingClassStudent =  _dbcontext.ClassStudents.FirstOrDefault(s => s.Id == classStudent.Id);
             if(ExistingClassStudent != null)
             {
                 ExistingClassStudent.ClasssId = classStudent.ClasssId;
                 ExistingClassStudent.StudentId = classStudent.StudentId;
                 
                 await _dbcontext.SaveChangesAsync();
             }
        }


            public async Task DeleteClassStudentAsync(DeleteClassStudentDTO classStudent)
            {
                var ExistingClassStudent =  _dbcontext.ClassStudents.FirstOrDefault(s => s.Id == classStudent.Id);
                if(ExistingClassStudent != null)
                {
                    _dbcontext.ClassStudents.Remove(ExistingClassStudent);
                    await _dbcontext.SaveChangesAsync();
                }
            }
    } 
}