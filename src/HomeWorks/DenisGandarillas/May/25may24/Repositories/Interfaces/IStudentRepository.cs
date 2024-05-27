using _25may24.Entities;

namespace _25may24.Repositories.Interfaces
{
    public interface IStudentRepository : IBaseRepository<Student>
    {

        Task<int> GetCareers(Guid idStudent);

    }
}
