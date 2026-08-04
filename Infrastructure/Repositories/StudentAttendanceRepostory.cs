using Domain.Entities;

using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class StudentAttendanceRepository : IStudentAttendance
    {
        private readonly ApplicationDbContext _dbcontext;
        public StudentAttendanceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendanceAsync()
        {
            return await _dbcontext.StudentAttendances.Select(s => new GetStudentAttendanceDTO
            {
                Id = s.Id,
                StudentId = s.StudentId,
                AttendanceId = s.AttendanceId,
                Datetime = s.DateAdded,
                UserAdded = s.UserAdded

            }).ToListAsync();
        }
        public async Task AddStudentAttendanceAsync(AddStudentAttendanceDTO studentAttendance)
        {
            _dbcontext.StudentAttendances.Add(new StudentAttendance
            {
               
                StudentId = studentAttendance.StudentId,
                AttendanceId = studentAttendance.AttendanceId,
                UserAdded = "Admin",
                DateAdded = DateTime.UtcNow

            });
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<GetStudentAttendanceDTO?> GetStudentAttendanceByIdAsync(int id)
        {
            return await _dbcontext.StudentAttendances.Where(s => s.Id == id).Select(s => new GetStudentAttendanceDTO
            {
                Id = s.Id,
                StudentId = s.StudentId,
                AttendanceId = s.AttendanceId,
                DateAdded = s.DateAdded,
                UserAdded = s.UserAdded

            }).FirstOrDefaultAsync();
        }
        public async Task UpdateStudentAttendanceAsync(UpdateStudentAttendanceDTO studentAttendance)
        {
            var ExistingStudentAttendance = _dbcontext.StudentAttendances.FirstOrDefault(s => s.Id == studentAttendance.Id);
            if (ExistingStudentAttendance != null)
            {
        
                ExistingStudentAttendance.StudentId = studentAttendance.StudentId;
                ExistingStudentAttendance.AttendanceId = studentAttendance.AttendanceId;

                await _dbcontext.SaveChangesAsync();
            }
        }
        public async Task DeleteStudentAttendanceAsync(DeleteStudentAttendanceDTO student)
        {
            var ExistingStudentAttendance = _dbcontext.StudentAttendances.FirstOrDefault(s => s.Id == student.Id);
            if (ExistingStudentAttendance != null)
            {
                _dbcontext.StudentAttendances.Remove(ExistingStudentAttendance);
                await _dbcontext.SaveChangesAsync();
            }
        }

        public Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync()
        {
            throw new NotImplementedException();
        }
    }
}