using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using University.Domain;
namespace University.Persistence;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase
{
  protected readonly PostgresContext context;
  protected DbSet<T> Entities => context.Set<T>();

  protected BaseRepository(PostgresContext context)
  {
    this.context = context;
  }

  public async Task<int> Create(T entity)
  {
    await Entities.AddAsync(entity);
    return await context.SaveChangesAsync();
  }

  public async Task<int> Update(T entity)
  {
    Entities.Update(entity);
    return await context.SaveChangesAsync();
  }

  public async Task<bool> Delete(T entity)
  {
    Entities.Remove(entity);
    return await context.SaveChangesAsync() > 0;
  }

  public async Task<IList<T>> Read(Expression<Func<T, bool>> lambda)
  {
    return await Entities.Where(lambda).ToListAsync();
  }

  public async Task<T?> GetById(Guid id)
  {
    return await Entities.FirstOrDefaultAsync(x => x.Id.Equals(id));
  }

  public async Task<IList<T>> GetByPage(Expression<Func<T, bool>> lambda, int pageNumber, int pageSize)
  {
    return await Entities
      .Where(lambda)
      .Skip((pageNumber - 1) * pageSize)
      .Take(pageSize)
      .ToListAsync();
  }

  public void Dispose()
  {
    if (context != null)
      context.Dispose();
  }


}
