using Domain.ValueObjects;
namespace Application.DTOs

{
    public class AddStudentAttendanceDTO
    {
         public int Id{get;set;}
        public int StudentId{get;set;}
        public int AttendanceId{get;set;}
        public string Name{get;set;}
        public DateTime Time{get;set;}
        public StudentAttendanceStatus Status{get;set;}
    }
    public class UpdateStudentAttendanceDTO
    {
         public int Id{get;set;}
        public int StudentId{get;set;}
        public int AttendanceId{get;set;}
        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
        public StudentAttendanceStatus Status{get;set;}
    }
    public class GetStudentAttendanceDTO
    {
         public int Id{get;set;}
        public int StudentId{get;set;}
        public int AttendanceId{get;set;}
        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
        public StudentAttendanceStatus Status{get;set;}
        public object Datetime { get; set; }
        public object UserAdded { get; set; }
    }
    public class DeleteStudentAttendanceDTO
    {
         public int Id{get;set;}
      
    }

  }