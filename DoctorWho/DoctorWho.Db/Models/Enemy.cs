using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime ModifiedAt { get; } = DateTime.Now;
    }
}
