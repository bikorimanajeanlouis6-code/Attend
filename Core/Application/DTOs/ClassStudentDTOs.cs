using Domain.Entities;
using Domain.ValueObjects;
namespace Application.DTOs
{
    public class GetClassStudentDTO
    {
        public int Id { get; set; }
        public int ClasssId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserAdded { get; set; }
        public ClassStudentStatus Status { get; set; }
        public Classs Classs {get;set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Student Student{get;set;}
    }
    public class AddClassStudentDTO
    {
        public int ClasssId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserAdded { get; set; }
        public string Status { get; set; }
    }
    public class UpdateClassStudentDTO
    {
        public int Id { get; set; }
        public int ClasssId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserAdded { get; set; }
        public string Status { get; set; }
    }
    public class DeleteClassStudentDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}