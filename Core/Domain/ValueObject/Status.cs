namespace Domain.ValueObjects
    {
        public enum StudentStatus
        {
            Active,
            Suspended,
            Repeated,
            Promoted,
            Dropped,
            Deleted 
        }
        public enum ClassStatus
        {
            Active,
            Full,
            Ongoing,
            Deleted
        }
        public enum ClassStudentStatus
        {
            Active,
            Promoted,
            Suspended,
            Dropped,
            Repeated,
        }
        public enum AttendanceStatus
    {
       Active,
       Deleted, 
    }
    public enum StudentAttendanceStatus
    {
         Suspended,
         Repeated,
         Promoted,
         Active,
         Deleted,
         Absent,
         present,
    }
    public enum StudentSex
    {
        Male,
        Female,
    }
}