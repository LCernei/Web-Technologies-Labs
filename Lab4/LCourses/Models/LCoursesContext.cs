using Microsoft.EntityFrameworkCore;

namespace LCourses.Models
{
    public class LCoursesContext : DbContext
    {
        public LCoursesContext (DbContextOptions<LCoursesContext> options)
            : base(options)
        {
        }

        public DbSet<LCourses.Models.Course> Course { get; set; }
    }
}