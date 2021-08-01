namespace DoctorWho.Db.Repositories
{
    public interface IRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        void SaveChanges();
    }
}
