using _25may24.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _25may24.Maps
{

  public class StudyMap : IEntityTypeConfiguration<Study>
  {

    public void Configure(EntityTypeBuilder<Study> builder)
    {

      builder.ToTable("Study");
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Id).ValueGeneratedOnAdd();
      builder.HasOne(p => p.Student).WithMany(s => s.Studies).HasForeignKey(x => x.IdStudent);
      builder.HasOne(p => p.Subject).WithMany(s => s.Studies).HasForeignKey(x => x.IdSubject);
      builder.Property(p => p.Semester);
      builder.Property(p => p.Grade);

    }

  }

}