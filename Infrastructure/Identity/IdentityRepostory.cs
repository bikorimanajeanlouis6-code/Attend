using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Domain.ValueObjects;
namespace Infrastructure.Identity
{
    
    public class IdentityRepository:IIdentity
    {
        private readonly ApplicationDbContext _dbcontext;
        // public readonly SignInManager<User> _signinManager;
        public readonly UserManager<User> _userManager;
        public readonly RoleManager<IdentityRole<int>> _roleManager;

    

     public IdentityRepository(ApplicationDbContext dbContext,  UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _dbcontext=dbContext;
            _userManager = userManager;
            _roleManager= roleManager;
        }


         public async Task<List<GetUserDTO>> GetAllUsersAsync()
        {
            return await _dbcontext.Users.Select(u=> new GetUserDTO
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                UserName = u.UserName,
                PhoneNumber = u.PhoneNumber,
                Status = u.Status,
                UserAdded= u.UserAdded,
                
            }).ToListAsync();
        }

         public async Task AddUserAsync(AddUserDTO user)
        {
           User newuser = new User()
           {
               FirstName = user.FirstName,
               LastName = user.LastName,
               DateAdded =DateTime.UtcNow,
               Email = user.Email,
               EmailConfirmed = true,
               UserName = user.Email,
               PhoneNumber = user.PhoneNumber,
               Status = UserStatus.Active,
               UserAdded ="Admin"

           };


           var result = await _userManager.CreateAsync(newuser, user.Password);
           if (!result.Succeeded)
            {
                var errors = string.Join(" User Creation Error: ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException($"Failed to create user: {errors}");
            }
            if (!string.IsNullOrEmpty(user.Role))
            {
                await _userManager.AddToRoleAsync(newuser, user.Role);
            }
           }
           
           
              }
}
