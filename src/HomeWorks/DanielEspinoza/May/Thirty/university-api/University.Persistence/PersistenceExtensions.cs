using Microsoft.Extensions.DependencyInjection;
using University.Domain;
namespace University.Persistence;

public static class PersistenceExtensions
{
    public static void AddPersistence(this IServiceCollection services, string connectionString)
    {
        services.AddNpgsql<PostgresContext>(connectionString);
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ICareerRepository, CareerRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}