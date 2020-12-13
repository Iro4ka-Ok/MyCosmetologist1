using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Data.Core.Interfaces;

namespace MyCosmetologist.Data.Core
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbContext Context;

        protected BaseRepository(DbContext context)
        {
            Context = context;
        }

        public virtual async Task<T> GetById(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public virtual IQueryable<T> GetAllQueryable()
        {
            return Context.Set<T>();
        }


        public virtual async Task Add(T entity, bool autoCommit = true)
        {
            Context.Set<T>().Add(entity);

            if (autoCommit)
            {
                await SaveChanges();
            }
        }

        public virtual async Task Update(T entity, bool autoCommit = true)
        {
            Context.Entry(entity).State = EntityState.Modified;

            if (autoCommit)
            {
                await SaveChanges();
            }
        }
        
        public virtual async Task Delete(int id, bool autoCommit = true)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                await Delete(entity, autoCommit);
            }
        }

        public virtual async Task Delete(T entity, bool autoCommit = true)
        {
            Context.Set<T>().Remove(entity);

            if (autoCommit)
            {
                await SaveChanges();
            }
        }


        public async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}