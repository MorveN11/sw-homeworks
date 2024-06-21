namespace University.Domain;

public interface IUnitOfWork: IDisposable
{
        IStudentRepository Students { get; }
        ICareerRepository Careers { get; }
        Task<int> SaveChangesAsync();
}
