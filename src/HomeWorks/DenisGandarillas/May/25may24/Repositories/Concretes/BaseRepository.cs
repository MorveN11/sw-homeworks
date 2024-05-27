using _25may24.Context;
using _25may24.Entities;
using _25may24.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _25may24.Repositories.Concretes
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase, new ()
    {

        protected readonly PostgresContext context;

        protected BaseRepository (PostgresContext context)
        {
            this.context = context;
        }

        public async Task<int> Create(T entity)
        {
            context.Set<T>().Add(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<int> Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<T> GetById(Guid id)
        {
            var response = await context.Set<T>().FirstAsync(t => t.Id.Equals(id));
            return response;
        }

        public async Task<IList<T>> Read(Expression<Func<T, bool>> lambda)
        {
            lambda.Compile();
            return await context.Set<T>().Where(lambda).ToListAsync();
        }

        public async Task<int> Update(T entity)
        {
            context.Set<T>().Update(entity);
            return await context.SaveChangesAsync();
        }

    }
}
