﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class Episode
    {
        public int EpisodeId { get; set; }

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

        public Author Author { get; set; }
        public Doctor Doctor { get; set; }

        [MaxLength(1800)]
        public string Notes { get; set; }
    }
}