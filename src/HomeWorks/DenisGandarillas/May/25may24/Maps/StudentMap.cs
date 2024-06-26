using _25may24.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _25may24.Maps
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.ToTable("Student");
            builder.HasIndex(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name);
            builder.Property(p => p.Lastname);
            builder.Property(p => p.Birthday);
            builder.HasMany(p => p.Studies).WithOne(s => s.Student).HasForeignKey(x => x.IdStudent);
            builder.HasMany(p => p.Candidates).WithOne(c => c.Student).HasForeignKey(x => x.IdStudent);

        }
    }
}
