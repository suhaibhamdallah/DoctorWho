using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository : Repository<Episode, int>
    {
        public EpisodeRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
