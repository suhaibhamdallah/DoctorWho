namespace DoctorWho.Db.Entities
{
    public interface IModel<TId>
    {
        TId Id { get; set; }
    }
}
