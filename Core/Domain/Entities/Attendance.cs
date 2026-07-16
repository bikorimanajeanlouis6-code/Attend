

namespace Domain.Entities
{
   public class Attendance
   {
      public int Id{get;set;}
      public int StudentId{get;set;}
      public int ClassId{get;set;}
      public DateTime GetDateTime{get;set;}
      public String Status {get;set;}


      public int Student{get;set;}
      public int Class{get;set;}


   }
}