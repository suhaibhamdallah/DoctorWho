using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Entities
{
    public class Companion : IModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanionName { get; set; }

        [MaxLength(200)]
        public string WhoPlayed { get; set; }
    }
}
