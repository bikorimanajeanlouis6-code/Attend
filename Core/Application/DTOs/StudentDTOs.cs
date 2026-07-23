namespace Application.DTOs
{
    public class AddStudentDTO
    {
        public string Name{get;set;}
        public DateTime DateofBirth{get;set;}
        public string Sex{get;set;}
        public string Phone{get;set;}
        public string MatherName{get;set;}
        public string FatherName{get;set;}
        public string FatherPhoneNmuber{get;set;}
        public string MatherPhoneNumber{get;set;}
        public string RegNumber{get;set;}
        public string Address{get;set;}
         public string Email{get;set;}
    }

    public class UpdateStudentDTO
    {
         public int Id {get;set;}
        public string Name{get;set;}
        public DateTime DateofBirth{get;set;}
        public string Address{get;set;}
        public string Sex{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public string MatherName{get;set;}
        public string FatherName{get;set;}
        public string FatherPhoneNmuber{get;set;}
        public string RegNumber{get;set;}
        public string MatherPhoneNumber{get;set;}
    }
    public class GetStudentDTO
    {
         public int Id{get;set;}
        public string Name{get;set;}
        public DateTime DateofBirth {get;set;}
        public string Sex {get; set;}
        public string Email{get;set;}
        public string Phone{ get;set;}
        public string RegNumber{get;set;}
        public string Address{get;set;}
        public string FatherName{get;set;}
        public string MatherName{get;set;}
        public string FatherPhoneNmuber{get;set;}
        public string MatherPhoneNumber{get;set;}
        public string UserAdded{get;set;}
        public DateTime DateAdded{get;set;}
        public string Status{get;set;}
        
    }
    public class DeleteStudentDTO
    {
         public int Id {get;set;}
        
    }
}



