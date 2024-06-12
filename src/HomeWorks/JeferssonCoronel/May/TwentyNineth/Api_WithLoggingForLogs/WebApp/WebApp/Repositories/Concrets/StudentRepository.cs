
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entity;
using WebApp.Repositories.Concrets;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(MyDBContext context) : base(context)
    {
    }

    public async Task<List<Career>> GetCareers(Guid idStudent)
    {
        var student = await context
            .Set<Student>()
                .Include((s) => s.Careers)
                .FirstAsync((s) => s.Id.Equals(idStudent));
        return student.Careers;
    }
}
