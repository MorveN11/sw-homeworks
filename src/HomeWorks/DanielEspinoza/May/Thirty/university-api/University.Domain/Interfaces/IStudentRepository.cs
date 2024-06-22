namespace University.Domain;

public interface IStudentRepository: IBaseRepository<Student>
{
  Task<IList<Career>> GetCareers(Guid idStudent);
}
