using DoctorWho.Db.Entities;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository : Repository<EpisodeEnemy, EpisodeEnemy, int>
    {
        public EpisodeEnemyRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
