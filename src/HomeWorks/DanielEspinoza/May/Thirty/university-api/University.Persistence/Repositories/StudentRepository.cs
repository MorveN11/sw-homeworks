using Microsoft.EntityFrameworkCore;
using University.Domain;


namespace University.Persistence;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(PostgresContext context) : base(context){}

    public async Task<IList<Career>> GetCareers(Guid idStudent)
    {
        var student = await Entities
            .Include(s => s.Careers)
            .FirstAsync(s => s.Id.Equals(idStudent));
        return [.. student.Careers];
    }
}
