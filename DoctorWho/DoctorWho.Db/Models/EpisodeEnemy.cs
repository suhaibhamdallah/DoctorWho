namespace DoctorWho.Db.Models
{
    public class EpisodeEnemy
    {
        public int EpisodeEnemyId { get; set; }
        public Episode Episode { get; set; }
        public Enemy Enemy { get; set; }
    }
}
