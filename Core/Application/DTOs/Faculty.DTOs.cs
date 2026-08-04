namespace Application.DTOs
{
    public class AddFacultyDTO
    {
         public int Id{get;set;}
        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
         public string UserAdded{get;set;}
         public string Status{get;set;} 

    }
    public class UpdateFacultyDTO
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
        public string UserAdded{get;set;}
        public string Status{get;set;} 
    }
    public class GetFacultyDTO
    {
        public int Id{get;set;}

        public string Name{get;set;}
        public DateTime DateAdded{get;set;}
         public string UserAdded{get;set;}
         public string Status{get;set;} 
    }
     public class DeleteFacultyDTO

    {
        public int Id{get;set;}
    }

}    