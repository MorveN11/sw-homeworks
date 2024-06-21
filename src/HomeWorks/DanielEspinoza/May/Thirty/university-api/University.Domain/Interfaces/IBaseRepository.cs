using System.Linq.Expressions;
namespace University.Domain;

public interface IBaseRepository<T>: IDisposable where T : IEntityBase
{
  Task<int> Create(T entity);
  Task<int> Update(T entity);
  Task<bool> Delete(T entity);
  Task<IList<T>> Read(Expression<Func<T, bool>> lambda);
  Task<T?> GetById(Guid id);
  Task<IList<T>> GetByPage(Expression<Func<T, bool>> lambda, int pageNumber, int pageSize);
}
