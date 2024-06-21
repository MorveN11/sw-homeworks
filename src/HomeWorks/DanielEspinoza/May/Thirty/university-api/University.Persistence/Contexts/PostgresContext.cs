using Microsoft.EntityFrameworkCore;
namespace University.Persistence;

public class PostgresContext: DbContext
{
  public PostgresContext(DbContextOptions<PostgresContext> options) : base(options){ }

  protected override void OnModelCreating(ModelBuilder builder) 
  {
    builder.ApplyConfigurationsFromAssembly(typeof(PostgresContext).Assembly);
    base.OnModelCreating(builder);
  }
}
