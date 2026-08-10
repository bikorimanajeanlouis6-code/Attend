
using Domain.ValueObjects;
namespace Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public int ClasssId { get; set; }
        public DateTime Date { get; set; }
        public AttendanceStatus Status { get; set; }
        public string InstructorName { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateTime { get; set; }
        //navigation property for relationship(FK)
        public Classs Classs { get; set; }
        public string UserAdded { get; set; }


    }
}