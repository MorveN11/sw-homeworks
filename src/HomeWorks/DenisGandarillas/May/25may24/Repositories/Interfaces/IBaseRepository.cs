using _25may24.Entities;
using System.Linq.Expressions;

namespace _25may24.Repositories.Interfaces
{
    public interface IBaseRepository<T> : IDisposable where T : IEntityBase, new ()
    {

        Task<int> Create(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
        Task<IList<T>> Read(Expression<Func<T, bool>> lambda);
        Task<T> GetById(Guid id);

    }
}
