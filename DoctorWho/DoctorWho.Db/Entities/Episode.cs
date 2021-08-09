using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Entities
{
    public class Episode : IModel<int>
    {
        public int Id { get; set; }

        [Required]
        public int SeriesNumber { get; set; }

        [Required]
        public int EpisodeNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string EpisodeType { get; set; }

        [Required]
        [MaxLength(200)]
        public string EpisodeTitle { get; set; }

        [Required]
        public DateTime EpisodeDate { get; set; }

        public int? AuthorId { get; set; }
        public Author Author { get; set; }
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [MaxLength(1800)]
        public string Notes { get; set; }
    }
}
