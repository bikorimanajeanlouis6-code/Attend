using Domain.ValueObjects;
namespace Domain.Entities
{
    public class StudentAttendance
    {
        public int Id{get;set;}
        public int StudentId{get;set;}
        public int AttendanceId{get;set;}
        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
        public string UserAdded { get; set; }
        public AttendanceStatus Status{get;set;}

        
        public Attendance Attendance{get;set;}
         public Student Student {get;set;}
        
      
    
    }
}