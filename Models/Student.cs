namespace CampusCore.Models
{
    public class Student
    {
        public int StudentId { get; set; } // DB PK
        public string Name { get; set; }

        public string StudentNumber { get; set; } // 7-digit
        public string RegistrationNumber { get; set; }

        public string Session { get; set; }
        public string BloodGroup { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public string GuardianContact { get; set; }
        public string District { get; set; }
        public string Upazila { get; set; }

        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public string Facebook { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
