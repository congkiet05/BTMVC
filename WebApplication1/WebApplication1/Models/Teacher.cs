namespace WebApplication1.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }

        public ICollection<ClassSection> ClassSections { get; set; }
    }
}
