using Application.DTOs;
using Application.Interfaces;
namespace Application.Services.EducationLevelServices
{
    public class EducationLevelService :IEducationLevelService
    {
         private readonly IEducationLevel _educationLevel;
        
        public EducationLevelService(IEducationLevel educationLevel)
        {
            _educationLevel=educationLevel;
        }
        public async Task<List<GetEducationLevelDTO>> GetAllEducationLevelAsync()
        {
            return await _educationLevel.GetAllEducationLevelAsync();
        }
         public async Task  AddEducationLevelAsync(AddEducationLevelDTO educationLevel)
        {
            await _educationLevel.AddEducationLevelAsync(educationLevel);
        }
         public async Task <GetEducationLevelDTO?> GetEducationLevelByIdAsync(int id)
        {
            return await _educationLevel.GetEducationLevelByIdAsync(id);
        }
         public async Task  UpdateEducationLevelAsync(UpdateEducationLevelDTO educationLevel)
        {
            await _educationLevel.UpdateEducationLevelAsync(educationLevel);
        }
        public async Task DeleteEducationLevelAsync(DeleteEducationLevelDTO educationLevel)
        {
             await _educationLevel.DeleteEducationLevelAsync(educationLevel);
        }
    }
}