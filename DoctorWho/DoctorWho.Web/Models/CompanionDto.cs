using System;

namespace DoctorWho.Web.Models
{
    public class CompanionDto
    {
        public int Id { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
