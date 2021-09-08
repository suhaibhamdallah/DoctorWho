using DoctorWho.Db.Models;

namespace DoctorWho.Web.Models
{
    public class CompanionDto : BaseModel
    {
        public int Id { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
    }
}
