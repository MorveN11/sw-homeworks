using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entity;

public class StudentCareerMap : IEntityTypeConfiguration<StudentCareer>
{
    public void Configure(EntityTypeBuilder<StudentCareer> builder)
    {
        builder.ToTable("StudentCareers");

        builder.HasKey(sc => sc.Id);

        builder.Property(sc => sc.Id)
            .ValueGeneratedOnAdd();

        builder.Property(sc => sc.StudentId)
            .IsRequired();

        builder.HasOne(sc => sc.Student)
            .WithMany(s => s.StudentCareers)
            .HasForeignKey(sc => sc.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(sc => sc.CareerId)
            .IsRequired();

        builder.HasOne(sc => sc.Career)
            .WithMany()
            .HasForeignKey(sc => sc.CareerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}