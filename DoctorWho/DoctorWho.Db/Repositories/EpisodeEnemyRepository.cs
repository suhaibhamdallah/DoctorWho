using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository : Repository<EpisodeEnemy>
    {
        public EpisodeEnemyRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
