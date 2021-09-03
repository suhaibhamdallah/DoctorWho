using DoctorWho.Db.Models;

namespace DoctorWho.Web.Models
{
    public class EnemytDto : BaseModel
    {
        public int Id { get; set; }
        public string EnemyName { get; set; }
        public string Description { get; set; }
    }
}
