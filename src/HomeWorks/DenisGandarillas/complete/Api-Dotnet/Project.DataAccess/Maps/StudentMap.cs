using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StudentMap : IEntityTypeConfiguration<Student>
{
  public void Configure(EntityTypeBuilder<Student> builder)
  {
    builder.ToTable("Student");
    builder.HasIndex(p => p.Id);
    builder.Property(p => p.Id).ValueGeneratedOnAdd();
    builder.Property(p => p.Name);
    builder.Property(p => p.LastName);
    builder.Property(p => p.BirthDate);

    builder.HasMany(p => p.Careers)
        .WithMany(p => p.Students)
        .UsingEntity<Dictionary<string, object>>(
            "CareerStudy",
            j => j.HasOne<Career>().WithMany().HasForeignKey("CareerId"),
            j => j.HasOne<Student>().WithMany().HasForeignKey("StudentId"));
  }
}

