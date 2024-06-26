using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain;
namespace University.Persistence;
public class CareerMap : IEntityTypeConfiguration<Career>
{
    public void Configure(EntityTypeBuilder<Career> builder)
    {
      builder.ToTable("Career");
      builder.HasIndex(p => p.Id);
      builder.Property(p => p.Id).ValueGeneratedOnAdd();
      builder.Property(p => p.Name);
      builder.Property(p => p.Code);

      builder.HasMany(p => p.Students)
          .WithMany(p => p.Careers)
          .UsingEntity<Dictionary<string, object>>(
              "CareerStudy",
              j => j.HasOne<Student>().WithMany().HasForeignKey("StudentId"),
              j => j.HasOne<Career>().WithMany().HasForeignKey("CareerId"));
    }
}

