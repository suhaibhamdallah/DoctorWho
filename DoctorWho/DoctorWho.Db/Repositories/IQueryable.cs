namespace DoctorWho.Db.Repositories
{
    public interface IQueryable<T>
    {
        T FindById(int entityId);
    }
}
