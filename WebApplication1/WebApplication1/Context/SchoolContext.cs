using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebApplication1.Models;
namespace WebApplication1.Context
{

    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassSection> ClassSections { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Có thể config thêm nếu cần
            base.OnModelCreating(modelBuilder);
        }
    }
}
