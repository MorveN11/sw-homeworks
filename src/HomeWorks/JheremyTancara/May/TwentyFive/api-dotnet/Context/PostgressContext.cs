using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using api_dotnet.Entities;
using Microsoft.EntityFrameworkCore;

public class PostgresContext : DbContext
{

    public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(PostgresContext).Assembly);
        base.OnModelCreating(builder);

        
    }
}
