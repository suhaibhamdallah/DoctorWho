using Microsoft.EntityFrameworkCore;
using System;

namespace DoctorWho.Db.Models
{
    public class EpisodesView
    {
        public int Id { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string EpisodeTitle { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int? AuthorId { get; set; }
        public Author Author { get; set; }
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string Notes { get; set; }
        public string AuthorName { get; set; }
        public string DoctorName { get; set; }
        public string Companions { get; set; }
        public string Enemies { get; set; }
    }
}
