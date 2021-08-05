namespace DoctorWho.Db.Models
{
    public class EpisodeCompanion : IModel<int>
    {
        public int Id { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }
        public int CompanionId { get; set; }
        public Companion Companion { get; set; }
    }
}
