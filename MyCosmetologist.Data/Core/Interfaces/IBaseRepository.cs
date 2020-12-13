using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Data.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(int id);
        IQueryable<T> GetAllQueryable();

        Task Add(T entity, bool autoCommit = true);
        Task Update(T entity, bool autoCommit = true);
        Task Delete(int id, bool autoCommit = true);
        Task Delete(T entity, bool autoCommit = true);

        Task SaveChanges();
    }
}