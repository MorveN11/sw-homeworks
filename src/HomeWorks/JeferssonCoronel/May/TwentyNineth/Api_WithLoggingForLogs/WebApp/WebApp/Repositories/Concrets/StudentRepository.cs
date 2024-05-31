
using WebApp.Context;
using WebApp.Entity;
using WebApp.Repositories.Concrets;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(MyDBContext context) : base(context)
    {
    }

    public Task<int> GetCareers(Guid idStudent)
    {
        throw new NotImplementedException();
    }
}
