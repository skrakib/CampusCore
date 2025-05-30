namespace CampusCore.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }

        public int? DeanId { get; set; } // Points to Teacher
        public Teacher? Dean { get; set; }

        public ICollection<Department> Departments { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
