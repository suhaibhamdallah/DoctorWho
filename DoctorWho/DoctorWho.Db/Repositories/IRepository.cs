using System.Collections.Generic;

namespace DoctorWho.Db.Repositories
{
    public interface IRepository<TEntity, VEntity, TId>
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        VEntity FindById(TId id);
        IEnumerable<VEntity> FindAll();
        void SaveChanges();
    }
}
