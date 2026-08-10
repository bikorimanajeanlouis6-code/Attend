using Domain.Entities;
using Domain.ValueObjects;
namespace Application.DTOs

{
    public class AddStudentAttendanceDTO
    {
         public int Id{get;set;}
        public int StudentId{get;set;}
        public int AttendanceId{get;set;}
        public int ClasssId{get;set;}
        public string Name{get;set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Time{get;set;}
        public AttendanceStatus Status{get;set;}
    }
    public class UpdateStudentAttendanceDTO
    {
         public int Id{get;set;}
        public int StudentId{get;set;}
        public int AttendanceId{get;set;}
        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
        public AttendanceStatus Status{get;set;}
    }
    public class GetStudentAttendanceDTO
    {
         public int Id{get;set;}
        public int StudentId{get;set;}
         public Student Student { get; set; }
        public int AttendanceId{get;set;}
        public string Name{get;set;}
        public Attendance Attendance { get; set; }
        
        public AttendanceStatus Status{get;set;}
         public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public object UserAdded { get; set; }




        
    public class DeleteStudentAttendanceDTO
    {
         public int Id{get;set;}
        public AttendanceStatus Status{get;set;}
      
    }

    }
}