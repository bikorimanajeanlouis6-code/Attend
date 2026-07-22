using Application.Interfaces;
using Application.DTOs;
using Domain.Entities;
namespace Application.Services.StudentServices
{
    public class StudentService:IStudentService
    {
        private readonly IStudent _student;
        
        public StudentService(IStudent student)
        {
            _student=student;
        }
        public async Task<List<GetStudentDTO>> GetAllStudentsAsync()
        {
            return await _student.GetAllStudentsAsync();
        }
        public async Task  AddStudentAsync(AddStudentDTO student)
        {
            await _student.AddStudentAsync(student);
        }
         public async Task <GetStudentDTO?> GetStudentByIdAsync(int id)
        {
            return await _student.GetStudentByIdAsync(id);
        }
        public async Task  UpdateStudentAsync(UpdateStudentDTO student)
        {
            await _student.UpdateStudentAsync(student);
        }
        public void DeleteStudent(DeleteStudentDTO student)
        {
             _student.DeleteStudent(student);
        }

    }

}