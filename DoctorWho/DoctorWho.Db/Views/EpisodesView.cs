﻿using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Models
{
    [Keyless]
    public class EpisodesView
    {
        public string AuthorName { get; set; }
        public string DoctorName { get; set; }
        public string Companions { get; set; }
        public string Enemies { get; set; }
    }
}
