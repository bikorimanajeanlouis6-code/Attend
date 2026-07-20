namespace Domain.Entities
{
    public class StudentAttendance
    {
        public int Id{get;set;}
        public int StudentId{get;set;}
        public int AttendanceId{get;set;}
        public string Name{get;set;}
        public DateTime GetDateTime{get;set;}
        public string Status{get;set;}

        
         public Attendance attendance{get;set;}
         public Student Students {get;set;}
    }
}