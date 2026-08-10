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
       Present,
       Absent,
       Late,
       UnTaken,
       Excused,
       Deleted, 
    }
    public enum StudentAttendanceStatus
    {
         Active,
         Deleted,
         Status,
         Absent,
         Present,
    }
    public enum StudentSex
    {
        Male,
        Female,
    }
}