using Application.DTOs;
using Application.Interfaces;
using Infrastructure.Data;
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AttendanceRepository:IAttendance
    {
        private readonly ApplicationDbContext _dbcontext;
        public AttendanceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<GetAttendanceDTO>> GetAllAttendanceAsync()
        {
            return await _dbcontext.Attendances
            .Include(a => a.Classs)
            
            .Select(a => new GetAttendanceDTO
            {
              Classs= a.Classs,
              Date = a.Date,
              Id = a.Id,
              ClasssId = a.ClasssId,
              InstructorName = a.InstructorName,
            }).ToListAsync();
        }
        public async Task AddAttendanceAsync(AddAttendanceDTO attendance)
        {
            await _dbcontext.Attendances.AddAsync(
                new Attendance
                {
                    InstructorName = attendance.InstructorName,
                    ClasssId = attendance.ClasssId,
                    Status = AttendanceStatus.Active,
                    Date = attendance.Date,
                    UserAdded = "Admin",
                    DateTime = DateTime.UtcNow
                }

            );
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<List<GetStudentAttendanceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendanceDTO attendance)
        {
           
            var attendanceEntity = new Attendance
            {
                ClasssId= attendance.ClasssId,
                InstructorName = attendance.InstructorName,
                Date = attendance.Date,
                UserAdded =attendance.InstructorName,
                DateTime = DateTime.UtcNow,
                Status= AttendanceStatus.Active
            };
            await _dbcontext.Attendances.AddAsync(attendanceEntity);
            await _dbcontext.SaveChangesAsync();

           
            var activeStudentIds = await _dbcontext.ClassStudents
            .Where(r => r.ClassId == attendance.ClasssId && r.Status == ClassStudentStatus.Active)
            .Select(r => r.StudentId)
            .ToListAsync();
           
            var studentAttendanceEntity = activeStudentIds.Select(studentIds => new StudentAttendance
            {
               StudentId = studentIds,
               Attendance = attendanceEntity,
               Status = AttendanceStatus.Absent,
             
               UserAdded= "Admin",
               
            }).ToList();
            await _dbcontext.StudentAttendances.AddRangeAsync(studentAttendanceEntity);
            await _dbcontext.SaveChangesAsync();
          
            return await _dbcontext.StudentAttendances
                .Include(sa => sa.Student)
                .Include(sa => sa.Attendance)
                .Where(sa => sa.AttendanceId == attendanceEntity.Id)
                .Select(sa => new GetStudentAttendanceDTO
                {
                    Id = sa.Id,
                    Student = sa.Student,
                    StudentId = sa.StudentId,
                    Attendance = sa.Attendance,
                    AttendanceId = sa.AttendanceId,
                    Status = sa.Status,
                    UserAdded = sa.UserAdded,
                    DateAdded = sa.DateAdded
                })
                .ToListAsync();
        }


        public async Task<GetAttendanceDTO?> GetAttendanceByIdAsync(int id)
        {
            return await _dbcontext.Attendances.Where(a => a.Id == id).Select(a => new GetAttendanceDTO
            {
                Id = a.Id,
                ClasssId = a.ClasssId,
                InstructorName = a.InstructorName,
                Date = a.Date,
                Classs = a.Classs
            }).FirstOrDefaultAsync();
        }
    }
}


