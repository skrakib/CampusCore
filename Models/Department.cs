namespace CampusCore.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public int? ChairmanId { get; set; } // Points to Teacher
        public Teacher? Chairman { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
