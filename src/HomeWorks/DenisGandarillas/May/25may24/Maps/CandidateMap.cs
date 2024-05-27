using _25may24.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _25may24.Maps
{

  public class CandidateMap : IEntityTypeConfiguration<Candidate>
  {

    public void Configure(EntityTypeBuilder<Candidate> builder)
    {

      builder.ToTable("Candidate");
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Id).ValueGeneratedOnAdd();
      builder.HasOne(p => p.Career).WithMany(s => s.Candidates).HasForeignKey(x => x.IdCareer);
      builder.HasOne(p => p.Student).WithMany(s => s.Candidates).HasForeignKey(x => x.IdStudent);
      builder.Property(p => p.Semester);

    }

  }
}