using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class Enemy : IModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string EnemyName { get; set; }

        [MaxLength(1800)]
        public string Description { get; set; }
    }
}
