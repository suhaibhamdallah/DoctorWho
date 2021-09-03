using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class Companion : BaseModel, IModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanionName { get; set; }

        [MaxLength(200)]
        public string WhoPlayed { get; set; }
    }
}
