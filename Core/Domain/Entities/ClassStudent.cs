namespace Domain.Entities
{
    public class ClassStudent{
        public int Id{get;set;}
        
        public int StudentId{get;set;}
        public Student Student{get;set;}

         

          public ICollection<Attendance> Attendances {get;set;}
         
         
    }
}