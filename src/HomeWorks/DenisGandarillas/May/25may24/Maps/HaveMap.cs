using _25may24.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _25may24.Maps
{

  public class HaveMap : IEntityTypeConfiguration<Have>
  {

    public void Configure(EntityTypeBuilder<Have> builder)
    {

      builder.ToTable("Have");
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Id).ValueGeneratedOnAdd();
      builder.HasOne(p => p.Subject).WithMany(s => s.Haves).HasForeignKey(x => x.IdSubject);
      builder.HasOne(p => p.Career).WithMany(c => c.Haves).HasForeignKey(x => x.IdCareer);
      builder.Property(p => p.Semester);

    }

  }

}