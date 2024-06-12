using WebApp.Entity;

namespace WebApp.Repositories.Interfaces
{
    public interface ICareerRepository : IBaseRepository<Career>
    {
        Task<List<Student>> GetStudents(Guid careerId);
    }
}
