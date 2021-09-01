using System;

namespace DoctorWho.Web.Models
{
    public class EpisodeDto
    {
        public int Id { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string EpisodeTitle { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int? AuthorId { get; set; }
        public int? DoctorId { get; set; }
        public string Notes { get; set; }
        public string AuthorName { get; set; }
        public string DoctorName { get; set; }
        public string Companions { get; set; }
        public string Enemies { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
