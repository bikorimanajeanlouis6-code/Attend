using Domain.Entities;

using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories

 {
    public class StudentAttendanceRepository:IStudentAttendance
    {
        private readonly ApplicationDbContext _context;
        public StudentAttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync()
        {
            return await _context.StudentAttendances
                .Include(sa => sa.Student)
                .Include(sa => sa.Attendance)
                .Select(sa => new GetStudentAttendanceDTO
                {
                    Id = sa.Id,
                    Student = sa.Student,
                    StudentId = sa.StudentId,
                    Attendance = sa.Attendance,
                    AttendanceId = sa.AttendanceId,
                    Status = sa.Status,
                    DateAdded = sa.DateAdded,
                    UserAdded = sa.UserAdded
                }).ToListAsync();
        }     

       
          public async Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus status)
        {
            var existing = await _context.StudentAttendances.FindAsync(AttendanceId);
           if (existing == null)
            {
                throw new InvalidOperationException("Student attendance record not found.");
            }
            existing.Status = status;
            await _context.SaveChangesAsync();
        }
        




        // public async Task UpdateStudentAttendanceAsync(int AttendanceId, int StudentId, StudentAttendanceStatus status)
        // {
        //     var existing = await _context.StudentAttendances.FindAsync(AttendanceId);
        //    if (existing == null)
        //     {
        //         throw new InvalidOperationException("Student attendance record not found.");
        //     }
        //     existing.Status = status;
        //     await _context.SaveChangesAsync();
        // }

        
    
    public async Task<GetStudentAttendanceDTO?> GetStudentAttendanceByIdAsync(int id)
        {
            var studentAttendance = await _context.StudentAttendances
                .Include(sa => sa.Student)
                .Include(sa => sa.Attendance)
                .FirstOrDefaultAsync(sa => sa.Id == id);

            if (studentAttendance == null)
            {
                return null;
            }

            return new GetStudentAttendanceDTO
            {
                Id = studentAttendance.Id,
                Student = studentAttendance.Student,
                StudentId = studentAttendance.StudentId,
                Attendance = studentAttendance.Attendance,
                AttendanceId = studentAttendance.AttendanceId,
                Status = studentAttendance.Status,
                DateAdded = studentAttendance.DateAdded,
                UserAdded = studentAttendance.UserAdded
            };
        }
    }

}