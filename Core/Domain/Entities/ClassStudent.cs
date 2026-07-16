namespace Domain.Entities
{
    public class ClassStudent{
        public int Id{get;set;}
        
        public int StudentId{get;set;}


    

        public int Student{get;set;}

         public ICollection<Student> Students {get;set;}
         
    }
}