using System.Collections.Generic;

namespace DoctorWho.Db.Repositories
{
    public interface IRepository<TEntity, TId>
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity FindById(TId id);
        IEnumerable<TEntity> FindAll();
        void SaveChanges();
    }
}
