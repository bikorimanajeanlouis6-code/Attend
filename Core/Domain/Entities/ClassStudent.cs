using Domain.ValueObjects;

namespace Domain.Entities
{
    public class ClassStudent{
        public int Id { get; set; }

         //Prefic should match the Navigation property name
        public int ClasssId { get; set; }
        public int StudentId { get; set; }
        public string UserAdded{get;set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DateAdded{get;set; }
        public ClassStudentStatus Status{get;set;}


          //Nagivation properties
        public Classs Classs{ get; set;}
        public Student Student{ get; set;}

         

          
         
    }
}