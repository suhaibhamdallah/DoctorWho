namespace DoctorWho.Db.Models
{
    public interface IModel<TId>
    {
        TId Id { get; set; }
    }
}
