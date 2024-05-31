using Microsoft.EntityFrameworkCore;
using WebApp.Entity;

namespace WebApp.Context
{
    public class MyDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<StudentCareer> StudentCareers { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
