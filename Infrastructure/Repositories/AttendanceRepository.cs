using Domain.Entities;
using Application.DTOs;
using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Domain.ValueObjects;
namespace Infrastructure.Repositories
{
    public class AttendanceRepository : IAttendance
    {
        private readonly ApplicationDbContext _dbcontext;
        public AttendanceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;

        }
        public async Task<List<GetAttendanceDTO>> GetAllAttendanceAsync()
        {
            return await _dbcontext.Attendances.Select(s => new GetAttendanceDTO
            {


                
                Id = s.Id,
                Name = s.Name,
                ClasssId = s.ClasssId,
                Classs=s.Classs,
                Date = s.Date,
                Status = AttendanceStatus.Active,

            })
              .ToListAsync();

        }
        public async Task AddAttendanceAsync(AddAttendanceDTO Attendance)
        {
            _dbcontext.Attendances.Add(new Attendance
            {

                Name = Attendance.Name,
                ClasssId = Attendance.ClasssId,
                Classs=Attendance.Classs,
                Date = Attendance.Date,
                Status = AttendanceStatus.Active,
            });
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<GetAttendanceDTO?> GetAttendanceByIdAsync(int id)
        {
            return await _dbcontext.Attendances.Where(s => s.Id == id).Select(s => new GetAttendanceDTO
            {
                Id = s.Id,
                Name = s.Name,
                ClasssId = s.ClasssId,
                Date = s.Date,
                Status = s.Status

            }).FirstOrDefaultAsync();
        }
        public async Task UpdateAttendanceAsync(UpdateAttendanceDTO Attendance)
        {
            var ExistingAttendance = _dbcontext.Attendances.FirstOrDefault(s => s.Id == Attendance.Id);
            if (ExistingAttendance != null)
            {
                ExistingAttendance.Name = Attendance.Name;
                ExistingAttendance.ClasssId = Attendance.ClasssId;
                ExistingAttendance.Date = Attendance.Date;
             

                await _dbcontext.SaveChangesAsync();
            }
        }
        public async Task DeleteAttendanceAsync(DeleteAttendanceDTO Attendence)
        {
            var ExistingAttendance = _dbcontext.Attendances.FirstOrDefault(s => s.Id == Attendence.Id);
            if (ExistingAttendance != null)
            {
                ExistingAttendance.Status=AttendanceStatus.Deleted;
                _dbcontext.Attendances.Remove(ExistingAttendance);
                await _dbcontext.SaveChangesAsync();
            }
        }

        public Task<List<GetAttendanceDTO>> GetAllAttendancesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
