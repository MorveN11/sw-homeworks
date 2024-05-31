using WebApp.Entity;

public interface IStudentRepository: IBaseRepository<Student>
{
  Task<int> GetCareers(Guid idStudent);
}
