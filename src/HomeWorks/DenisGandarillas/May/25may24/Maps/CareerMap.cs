using _25may24.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _25may24.Maps
{
    public class CareerMap : IEntityTypeConfiguration<Career>
    {

        public void Configure(EntityTypeBuilder<Career> builder)
        {

            builder.ToTable("Career");
            builder.HasIndex(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name);
            builder.Property(p => p.Code);
            builder.HasMany(p => p.Haves).WithOne(h => h.Career).HasForeignKey(x => x.IdCareer);
            builder.HasMany(p => p.Candidates).WithOne(c => c.Career).HasForeignKey(x => x.IdCareer);

        }

    }
}
