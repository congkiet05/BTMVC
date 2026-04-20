namespace WebApplication1.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        // FK
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int ClassSectionId { get; set; }
        public ClassSection ClassSection { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
