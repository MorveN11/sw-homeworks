using Microsoft.EntityFrameworkCore;
using WebApp.Entity;

namespace WebApp.Context
{
    public class MyDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Career> Careers { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Careers)
                .WithMany(c => c.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "CareerStudent",
                    j => j.HasOne<Career>().WithMany().HasForeignKey("CareersId"),
                    j => j.HasOne<Student>().WithMany().HasForeignKey("StudentsId")
                );
        }
    }
}
