using DoctorWho.Db.Entities;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository : Repository<EpisodeCompanion, EpisodeCompanion, int>
    {
        public EpisodeCompanionRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
