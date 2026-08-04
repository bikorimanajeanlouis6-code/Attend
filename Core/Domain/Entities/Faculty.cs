using System.Net;

namespace Domain.Entities
{
    public class Faculty
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
         public string UserAdded{get;set;}
         public string Status{get;set;} 

         public ICollection<Classs> classses {get;set;}

       
    }
    
}
