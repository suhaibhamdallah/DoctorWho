using DoctorWho.Db.Models;
using System;

namespace DoctorWho.Web.Models
{
    public class DoctorForManipulationDto : BaseModel
    {
        public int? Id { get; set; }
        public int DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime BithDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
