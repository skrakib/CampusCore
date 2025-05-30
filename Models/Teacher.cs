namespace CampusCore.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FullName { get; set; }

        public string Designation { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public string BloodGroup { get; set; }
        public string District { get; set; }
        public string Upazila { get; set; }

        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public string Facebook { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
