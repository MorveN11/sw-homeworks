using WebApp.Entity;

public interface IStudentRepository: IBaseRepository<Student>
{
   Task<List<Career>> GetCareers(Guid studentId);
}
