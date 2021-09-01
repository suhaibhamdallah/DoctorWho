using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Models
{
    public class Doctor : IModel<int>
    {
        public int Id { get; set; }

        [Required]
        public int DoctorNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string DoctorName { get; set; }

        [Required]
        public DateTime BithDate { get; set; }

        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; }

        public DateTime ModifiedAt { get; set; } = DateTime.Now;
    }
}
