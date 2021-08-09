using DoctorWho.Db.Entities;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository : Repository<Episode, EpisodesView, int>
    {
        public EpisodeRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
