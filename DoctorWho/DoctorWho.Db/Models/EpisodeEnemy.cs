namespace DoctorWho.Db.Models
{
    public class EpisodeEnemy : IModel<int>
    {
        public int Id { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }
        public int EnemyId { get; set; }
        public Enemy Enemy { get; set; }
    }
}
