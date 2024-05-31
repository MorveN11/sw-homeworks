using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entity;

namespace WebApp.Repositories.Concrets
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase, new()
    {
        protected readonly MyDBContext context;

        protected BaseRepository(MyDBContext context)
        {
            this.context = context;
        }

        public async Task<int> Create(T entity)
        {
            context.Set<T>().Add(entity);
            return await context.SaveChangesAsync();
        }

        public Task<int> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<IList<T>> Read(Expression<Func<T, bool>> lambda)
        {
            lambda.Compile();
            return await context.Set<T>().Where(lambda).ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            var response = await context.Set<T>().FindAsync(id);
            return response;
        }

        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}