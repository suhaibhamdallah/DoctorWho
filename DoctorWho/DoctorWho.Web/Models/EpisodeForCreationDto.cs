using System;

namespace DoctorWho.Web.Models
{
    public class EpisodeForCreationDto
    {
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string EpisodeTitle { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int? AuthorId { get; set; }
        public int? DoctorId { get; set; }
        public string Notes { get; set; }
    }
}
