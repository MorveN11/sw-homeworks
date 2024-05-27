using _25may24.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _25may24.Maps
{

  public class SubjectMap : IEntityTypeConfiguration<Subject>
  {

    public void Configure(EntityTypeBuilder<Subject> builder)
    {

      builder.ToTable("Subject");
      builder.HasIndex(p => p.Id);
      builder.Property(p => p.Id).ValueGeneratedOnAdd();
      builder.Property(p => p.Name);
      builder.Property(p => p.Code);
      builder.Property(p => p.Credit);
      builder.HasMany(p => p.Studies).WithOne(s => s.Subject).HasForeignKey(x => x.IdSubject);
      builder.HasMany(p => p.Haves).WithOne(h => h.Subject).HasForeignKey(x => x.IdSubject);

    }

  }

}