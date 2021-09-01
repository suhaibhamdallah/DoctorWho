using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Models
{
    public class Companion : IModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanionName { get; set; }

        [MaxLength(200)]
        public string WhoPlayed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime ModifiedAt { get; } = DateTime.Now;
    }
}
