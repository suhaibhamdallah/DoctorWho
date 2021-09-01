using System;

namespace DoctorWho.Web.Models
{
    public class EnemytDto
    {
        public int Id { get; set; }
        public string EnemyName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
