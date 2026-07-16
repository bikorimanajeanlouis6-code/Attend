using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAttendance
    {
        public List<Attendance>GetAllAttendances();
    }
}