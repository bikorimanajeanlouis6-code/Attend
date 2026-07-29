namespace Application.DTOs
{
    public class AddAttendanceDTO
    {
        public int Id{get;set;}
        public int ClassId{get;set;}
        public DateTime Date{get;set;}
        public string Status{get;set;}
        public string Name{get;set;}
    }
    public class UpdateAttendanceDTO
    {
        public int Id{get;set;}
        public int ClassId{get;set;}
        public DateTime Date{get;set;}
        public string Status{get;set;}
        public string Name{get;set;}
    }
    public class GetAttendanceDTO
    {
        public int Id{get;set;}
        public int ClassId{get;set;}
        public DateTime Date{get;set;}
        public string Status{get;set;}
        public string Name{get;set;}

    }
    public class DeleteAttendanceDTO
    {
         public int Id{get;set;}
         public int ClassId{get;set;}
         public DateTime Date{get;set;}
         public string Status{get;set;}
         public string Name{get;set;}

    }
}