using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository : Repository<EpisodeCompanion, int>
    {
        public EpisodeCompanionRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
