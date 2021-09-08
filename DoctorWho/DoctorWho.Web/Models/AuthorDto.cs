using DoctorWho.Db.Models;

namespace DoctorWho.Web.Models
{
    public class AuthorDto : BaseModel
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
    }
}
