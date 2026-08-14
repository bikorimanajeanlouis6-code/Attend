using Domain.ValueObjects;
namespace Application.DTOs
{
    public class GetUserDTO
    {
        public int Id { get; set; }
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email{get;set;}
        public string PhoneNumber{get;set;}
        public UserStatus Status{get;set;}
        public string UserAdded{get;set;}
        public string UserName{get;set;}

    }
    public class AddUserDTO
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email{get;set;}
        public string PhoneNumber{get;set;}
    
        public string Password{get;set;}
        public string Role {get;set;}
    }
    public class LoginDTO
    {
         public string Email{get;set;}
        public string Password{get;set;}
        public bool RememberMe{get;set;}

    }
}