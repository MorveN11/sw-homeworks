using api_dotnet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_dotnet.Maps
{
    public class StudyMap : IEntityTypeConfiguration<Study>
    {
        public void Configure(EntityTypeBuilder<Study> builder)
        {
            builder.ToTable("Study");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Notas).IsRequired();

            builder.HasOne(s => s.Career)
                .WithMany()
                .HasForeignKey(s => s.CareerId);

            builder.HasOne(s => s.Student)
                .WithMany()
                .HasForeignKey(s => s.StudentId);
        }
    }
}
