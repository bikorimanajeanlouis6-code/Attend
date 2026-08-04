using Application.DTOs;
namespace Application.Interfaces
{
    public interface IEducationLevel
    {
         Task<List<GetEducationLevelDTO>> GetAllEducationLevelAsync();
        
        Task  AddEducationLevelAsync(AddEducationLevelDTO educationLevel);
        Task <GetEducationLevelDTO?> GetEducationLevelByIdAsync(int id);
        Task UpdateEducationLevelAsync(UpdateEducationLevelDTO educationLevel);
        Task DeleteEducationLevelAsync(DeleteEducationLevelDTO educationLevel);
         
    }
}