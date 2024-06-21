using University.Domain;
namespace University.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _context;
    private readonly IStudentRepository _student;
    private readonly ICareerRepository _career;
    public UnitOfWork(PostgresContext context, IStudentRepository students, ICareerRepository careers){
        _context = context;
        _student = students;
        _career = careers;
    }
    public IStudentRepository Students => _student;

    public ICareerRepository Careers => _career;

    public void Dispose()
    {
        _context.Dispose();

    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}