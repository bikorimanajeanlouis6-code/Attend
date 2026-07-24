using Domain.Entities;

using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly ApplicationDbContext _dbcontext;
        public StudentRepository(ApplicationDbContext dbcontext)
        {
              _dbcontext= dbcontext;
           
        }
        public async Task<List<GetStudentDTO>> GetAllStudentsAsync()
        {
            return await _dbcontext.Students.Select(s=> new GetStudentDTO
            {
                Id =s.Id,
                Name=s.Name,
                Address=s.Address,
                Sex=s.Sex,
                Phone=s.Phone,
                DateofBirth=s.DateofBirth,
                Email=s.Email,
                MatherName=s.MatherName,
                FatherName=s.FatherName,
                FatherPhoneNmuber=s.FatherPhoneNmuber,
                RegNumber=s.RegNumber,
                MatherPhoneNumber=s.MatherPhoneNumber,
                Status=s.Status,
                DateAdded=s.DateAdded,
                UserAdded=s.UserAdded

             }).ToListAsync();
        }
          public async Task AddStudentAsync(AddStudentDTO student)
        {
             _dbcontext.Students.Add(new Student
             {
                 Name =student.Name,
                 DateofBirth=student.DateofBirth,
                 Sex=student.Sex,
                 Phone=student.Phone,
                 RegNumber=student.RegNumber,
                 MatherName=student.MatherName,
                 FatherName=student.FatherName,
                 Email=student.Email,
                 Address=student.Address,
                 FatherPhoneNmuber=student.FatherPhoneNmuber,
                 MatherPhoneNumber=student.MatherPhoneNumber,
                 UserAdded="Admin",
                 DateAdded = DateTime.UtcNow,
                 Status="Active"
             }  );
            await _dbcontext.SaveChangesAsync();
        }
         public async Task<GetStudentDTO?> GetStudentByIdAsync(int id)
        {
            return await  _dbcontext.Students.Where(s => s.Id == id).Select(s=> new GetStudentDTO
            {
                 Id =s.Id,
                Name=s.Name,
                Address=s.Address,
                Sex=s.Sex,
                Phone=s.Phone,
                DateofBirth=s.DateofBirth,
                Email=s.Email,
                MatherName=s.MatherName,
                FatherName=s.FatherName,
                FatherPhoneNmuber=s.FatherPhoneNmuber,
                RegNumber=s.RegNumber,
                MatherPhoneNumber=s.MatherPhoneNumber
            }).FirstOrDefaultAsync();
        }
        public async Task UpdateStudentAsync(UpdateStudentDTO student)
        {
             var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.DateofBirth = student.DateofBirth;
                ExistingStudent.Address = student.Address;
                ExistingStudent.Phone = student.Phone;
                ExistingStudent.RegNumber=student.RegNumber;
                ExistingStudent.MatherName=student.MatherName;
                ExistingStudent.FatherName=student.FatherName;
                ExistingStudent.Email=student.Email;
                ExistingStudent.FatherPhoneNmuber=student.FatherPhoneNmuber;
                ExistingStudent.MatherPhoneNumber=student.MatherPhoneNumber;

               await _dbcontext.SaveChangesAsync();
            }
        }
        public async Task DeleteStudentAsync(DeleteStudentDTO student)
        {
            var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
            if(ExistingStudent != null)
            {
               
                await _dbcontext.SaveChangesAsync();
            }
        }
    }
}

    

