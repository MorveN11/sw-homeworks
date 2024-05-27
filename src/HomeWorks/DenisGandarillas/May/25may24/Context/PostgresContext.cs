using Microsoft.EntityFrameworkCore;

namespace _25may24.Context
{
    public class PostgresContext : DbContext
    {

        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgresContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
