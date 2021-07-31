namespace DoctorWho.Db.Models
{
    public class EpisodeCompanion
    {
        public int EpisodeCompanionId { get; set; }
        public Episode Episode { get; set; }
        public Companion Companion { get; set; }
    }
}
