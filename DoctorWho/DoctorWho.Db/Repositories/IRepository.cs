using System.Collections.Generic;

namespace DoctorWho.Db.Repositories
{
    public interface IRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        T FindById(int id);
        IEnumerable<T> FindAll();
        void SaveChanges();
    }
}
