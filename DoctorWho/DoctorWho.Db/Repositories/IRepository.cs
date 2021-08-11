using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public interface IRepository<TEntity, VEntity, TId>
    {
        Task<TEntity> Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        Task<VEntity> FindById(TId id);
        Task<IEnumerable<VEntity>> FindAll();
    }
}
