using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entity;

public class CareerMap : IEntityTypeConfiguration<Career>
{
    public void Configure(EntityTypeBuilder<Career> builder)
    {
        builder.ToTable("Careers");
        builder.HasIndex(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
        builder.Property(p => p.Code).IsRequired().HasMaxLength(255);

        builder.HasMany(p => p.StudentCareers)
               .WithOne(sc => sc.Career)
               .HasForeignKey(sc => sc.CareerId);
    }
}
